using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmSalariesManage : Telerik.WinControls.UI.RadForm
    {
        public FrmSalariesManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        private void TotalExpenses()
        {
            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("Amount", "الاجمالي={0}" + InformationsClass.Coin + " ", GridAggregateFunction.Sum);

            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.SalaryGridView.SummaryRowsBottom.Clear();
            this.SalaryGridView.SummaryRowsBottom.Add(summaryRowItem);
            

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddSalaries Addfrm = new FrmAddSalaries();
            Addfrm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void FrmSalariesManage_Load(object sender, EventArgs e)
        {

            Thread th = new Thread(FillSalaryData);
            th.Start();
            TotalExpenses();
            
        }

        private void FillSalaryData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = SalariesCmd.GetSalaryBySelectedprotID(InformationsClass.ProjID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                SalaryGridView.DataSource = q;
                StatusLabel1.Text = "";

            });
          
           
        }

        private void SalaryGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = SalaryGridView.CurrentColumn.Index;

            if (col == 8)
            {
                //
                Operation.BeginOperation(this);
                FrmSalaryMang frm = new FrmSalaryMang();
                Ucas.Data.Monthlysalary salary = (Ucas.Data.Monthlysalary)SalaryGridView.CurrentRow.DataBoundItem;
                frm.Tragetsalary = salary;
                frm.ShowDialog();
                Operation.EndOperation(this);
               
                return;

            }

            if (col == 9)
            {

                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {

                    if (SalariesCmd.DeleteSalary(int.Parse(SalaryGridView.CurrentRow.Cells[1].Value.ToString())))
                    {
                        Operation.BeginOperation(this);
                        Operation.ShowToustOk(OperationX.DeletedMessage, this);
                        Operation.EndOperation(this);
                        return;

                    }
                    else
                    {
                       Operation.EndOperation(this);
                       RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                    
                }

            }
        }

        private void PrintDraftBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            
            List<SalaryReportObj> ls = new List<SalaryReportObj>();
            int counter = 0;
        //    ls.Add(new SalaryReportObj() {  SalarysID = counter});
            foreach (GridViewRowInfo item in SalaryGridView.ChildRows)
            {
                counter++;
                ls.Add(new SalaryReportObj() {SalarysID=counter,
                 coin = item.Cells["Coin"].Value.ToString(),
                 //coin=  q[0].Coin,
                 EmployeejobNumber = item.Cells["EmployeejobNumber"].Value.ToString(),
                 EmployeeName = item.Cells["EmployeeName"].Value.ToString(),
                 //ProjectName=q[0].ProjectName,
                 ProjectName = item.Cells["ProjectName"].Value.ToString(),
                SalaryAmount = double.Parse(item.Cells["Amount"].Value.ToString()),
                SalaryForMonth = DateTime.Parse(item.Cells["Formonth"].Value.ToString()),
                SalaryIssueDate = DateTime.Parse(item.Cells["IssueDate"].Value.ToString())
                });
            }
            Reports.ReportCommand.SalaryReportCmd cmd = new Reports.ReportCommand.SalaryReportCmd();
            cmd.ShowReport(ls);
            Operation.EndOperation(this);
        }

        private void FrmSalariesManage_Activated(object sender, EventArgs e)
        { 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
          
            FrmSalariesManage_Load(sender, e);
           

        }

       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data;
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

            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("Amount", "المجموع الكلي = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.SalaryGridView.SummaryRowsBottom.Add(summaryRowItem);


        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddSalaries Addfrm = new FrmAddSalaries();
            Addfrm.ShowDialog();
        }

        private void FrmSalariesManage_Load(object sender, EventArgs e)
        {
            SalaryGridView.DataSource = SalariesCmd.GetSalaryBySelectedprotID(InformationsClass.ProjID);
            for (int i = 1; i <= SalaryGridView.Rows.Count; i++)
            {
                SalaryGridView.Rows[i - 1].Cells[0].Value = i.ToString();
            }

            TotalExpenses();
        }

        private void SalaryGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = SalaryGridView.CurrentColumn.Index;

            if (col == 7)
            {
                //
                this.Cursor = Cursors.WaitCursor;
                FrmSalaryMang frm = new FrmSalaryMang();
                Ucas.Data.Monthlysalary salary = (Ucas.Data.Monthlysalary)SalaryGridView.CurrentRow.DataBoundItem;
                frm.Tragetsalary = salary;
                frm.FillCombo();
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
               
                return;

            }

            if (col == 8)
            {

                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {

                    SalariesCmd.DeleteSalary(int.Parse(SalaryGridView.CurrentRow.Cells[1].Value.ToString()));
                    RadMessageBox.Show("تمت علمية الحذف");
                    return;
                }

            }
        }

        private void PrintDraftBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            
            List<SalaryReportObj> ls = new List<SalaryReportObj>();
            int counter = 0;
            foreach (GridViewRowInfo item in SalaryGridView.ChildRows)
            {
                counter++;
                ls.Add(new SalaryReportObj() { SalarysID = counter,
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
            this.Cursor = Cursors.Default;
        }

        private void FrmSalariesManage_Activated(object sender, EventArgs e)
        {
            FrmSalariesManage_Load(sender, e);
        }
    }
}
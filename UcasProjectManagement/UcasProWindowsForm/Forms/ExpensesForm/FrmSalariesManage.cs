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
            SalaryGridView.DataSource = SalariesCmd.GetAllSalaryBypro(InformationsClass.ProjID);
            for (int i = 1; i <= SalaryGridView.Rows.Count; i++)
            {
                SalaryGridView.Rows[i - 1].Cells[0].Value = i.ToString();
            }

            TotalExpenses();
        }

        private void SalaryGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = SalaryGridView.CurrentColumn.Index;

            if (col == 6)
            {
                FrmSalaryMang EditSalary = new FrmSalaryMang();
                EditSalary.FillCombo();
                EditSalary.XSalaryID = int.Parse(SalaryGridView.CurrentRow.Cells[1].Value.ToString());
                EditSalary.ContractComboBox.Text = SalaryGridView.CurrentRow.Cells[2].Value.ToString();
                EditSalary.SalaryTextBox.Text = SalaryGridView.CurrentRow.Cells[3].Value.ToString();
                EditSalary.FromonthDateTimePicker.Text = SalaryGridView.CurrentRow.Cells[4].Value.ToString();
                EditSalary.ReleaseDateTimePicker.Text = SalaryGridView.CurrentRow.Cells[5].Value.ToString();


                EditSalary.ShowDialog();
                return;

            }

            if (col == 7)
            {

                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
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
            var q = ProjectProfileCmd.GetProjectData(InformationsClass.ProjID);
            foreach (GridViewRowInfo item in SalaryGridView.ChildRows)
            {
                ls.Add(new SalaryReportObj() { SalarysID = int.Parse(item.Cells[0].Value .ToString()),
                 coin=  q[0].Coin,
                
                  EmployeeName=item.Cells[2].Value.ToString(),
                ProjectName=q[0].ProjectName,
                SalaryAmount=double.Parse( item.Cells[3].Value.ToString()),
                SalaryForMonth=DateTime.Parse( item.Cells[4].Value.ToString()),
                SalaryIssueDate=DateTime.Parse( item.Cells[5].Value.ToString())});
            }
            Reports.ReportCommand.SalaryReportCmd cmd = new Reports.ReportCommand.SalaryReportCmd();
            cmd.ShowReport(ls);
            this.Cursor = Cursors.Default;
        }
    }
}
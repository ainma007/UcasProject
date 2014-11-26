using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.ActivitiesForm;
using UcasProWindowsForm.Forms.AmountRecivedForms;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ExpensesForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmMainUserPro : Telerik.WinControls.UI.RadForm
    {
        public FrmMainUserPro()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        int ProID = ProjectControlCmd.ChkProjectIDByUserID(InformationsClass.xCurrentUserID);
        private void FrmMainUserPro_Load(object sender, EventArgs e)
        {
            
            var ListData = ProjectProfileCmd.GetProjectData(ProID);
            foreach (var item in ListData )
            {
                InformationsClass.ProjID = item.ID;
                this.radTextBox1.Text = item.ProjectName;
                this.DescTextBox.Text = item.ProjectDescription;
                this.StartDateTextBox.Text = item.StartDate.ToString ();
                this.EndDateTextBox.Text = item.EndDate.ToString ();
                this.radTextBox2.Text = item.TotalCost.ToString ();
                this.radTextBox3.Text = item.Coin.ToString();

                this.radTextBox1.Text = ProjectExpensesCmd.GetTotalExpensesByProject(InformationsClass.ProjID).ToString();
                

            }
            var TotalExpenses = ProjectExpensesCmd.GetTotalExpensesByProject(InformationsClass.ProjID).ToString();
            this.TotalExpensesTextBox.Text = TotalExpenses;

            //
            var TotalSalary = SalariesCmd.GetTotalSalaryByProject(InformationsClass.ProjID).ToString();
            this.TotalSalayTextBox.Text = TotalSalary;
            //

            var TotalAmountRecv = AmountsReceivedsCmd.GetTotalAmountsByProject(InformationsClass.ProjID).ToString();
            this.AmountRecvTextBox.Text = TotalAmountRecv;

            decimal val1 = Convert.ToDecimal(TotalExpensesTextBox.Text);
            decimal val2 = Convert.ToDecimal(TotalSalayTextBox.Text);
          
            decimal val3 = val1 + val2;
            decimal val4 = Convert.ToDecimal(AmountRecvTextBox.Text);
            RemainingTextBox.Text = (val4 - val3).ToString();

            //================================
            //BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            //barSeries.Name = "Q1";
            //barSeries.DataPoints.Add(new CategoricalDataPoint(100, "Harley"));
            //barSeries.DataPoints.Add(new CategoricalDataPoint(128, "White"));
            //barSeries.DataPoints.Add(new CategoricalDataPoint(143, "Smith"));
            //barSeries.DataPoints.Add(new CategoricalDataPoint(111, "Jones"));
            //barSeries.DataPoints.Add(new CategoricalDataPoint(118, "Marshall"));
            //this.ProjectChart.Series.Add(barSeries);
           
            chart1.Series[0].Points.AddXY("اجمالي الايرادات", val4);
            chart1.Series[0].Points.AddXY("اجمالي المصاريف", val1);
            chart1.Series[0].Points.AddXY("اجمالي الرواتب",val2);
            chart1.Series[0].Points.AddXY("المتبقي من الرصيد",RemainingTextBox.Text);
            chart1.Titles.Add("مخطط موجز الحسابات للمشروع");
            

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.ChartAreas[0].BackColor = Color.Azure;
            
            chart1.ChartAreas[0].ShadowColor = Color.Red;

        ///    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        }

        private void ProjectManageBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmTheDonorsAndProjectManage frm =new FrmTheDonorsAndProjectManage();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void ContractsBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmContratsManage ContrMng = new FrmContratsManage();
            ContrMng.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void FrmMainUserPro_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Dispose();
            

           
        }

        private void ActivitesBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAllActivitesMange Activfrm = new FrmAllActivitesMange();
            Activfrm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void ExpensesBTn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmManageExpenses frm = new FrmManageExpenses();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
          //  this.Cursor = Cursors.WaitCursor;
            FrmSalariesManage frm = new FrmSalariesManage();
            frm.ShowDialog();
          //  this.Cursor = Cursors.Default;
        }

        private void AmountRrecvBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmMangeAmount frm = new FrmMangeAmount();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void Expenseslbl_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
           
        }

        private void Expenses_Rbt_btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.ReportCommand.ExpensessReportCmd cmd = new Reports.ReportCommand.ExpensessReportCmd();
            cmd.GetByProjectId(InformationsClass.ProjID);
            this.Cursor = Cursors.Default;
        }

        private void Salary_rbt_btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Reports.ReportCommand.SalaryReportCmd cmd = new Reports.ReportCommand.SalaryReportCmd();
            cmd.GetByProjectId(InformationsClass.ProjID);
            this.Cursor = Cursors.Default;
        }
    }
}

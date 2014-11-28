using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using Ucas.Data;
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
        ProjectProfile db = new ProjectProfile();
        public ProjectProfile TragetProject { get; set; }


        public string Progress { get; set; }
        private void FrmMainUserPro_Load(object sender, EventArgs e)
        {
            db = new ProjectProfile();
            InformationsClass.ProjID = TragetProject.ID;
            var ListData = ProjectProfileCmd.GetProjectData(InformationsClass.ProjID);
            foreach (var item in ListData)
            {
               
                this.radTextBox1.Text = item.ProjectName;
                this.DescTextBox.Text = item.ProjectDescription;
                this.StartDateTextBox.Text = item.StartDate.ToString();
                this.EndDateTextBox.Text = item.EndDate.ToString();
                this.radTextBox2.Text = item.TotalCost.ToString();
                this.radTextBox3.Text = item.Coin.ToString();

                this.Progress = item.progress.ToString();


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

         
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();
            chart1.Series[0].Points.AddXY("اجمالي الايرادات", val4);
            chart1.Series[0].Points.AddXY("اجمالي المصاريف", val1);
            chart1.Series[0].Points.AddXY("اجمالي الرواتب",val2);
            chart1.Series[0].Points.AddXY("المتبقي من الرصيد",RemainingTextBox.Text);
            chart1.Titles.Add("مخطط موجز الحسابات للمشروع");
            chart1.Series[0].Points[0].Color = Color.YellowGreen;
            chart1.Series[0].Points[1].Color = Color.Red;
            chart1.Series[0].Points[2].Color = Color.Red;
            chart1.Series[0].Points[3].Color = Color.YellowGreen;
            
            
            decimal Residual = 100 -decimal.Parse(Progress);
            chart2.Series[0].Points.Clear();
            
            chart2.Series[0].Points.AddXY("نسبة الانجاز", Progress);
            chart2.Series[0].Points.AddXY("المتبقى", Residual);
            chart2.Series[0].IsValueShownAsLabel = true;
            
            chart2.Series[0].Points[0].Color = Color.SkyBlue;
            chart2.Series[0].Points[1].Color = Color.Crimson;

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
           this.Cursor = Cursors.WaitCursor;
            FrmSalariesManage frm = new FrmSalariesManage();
            frm.ShowDialog();
           this.Cursor = Cursors.Default;
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmMainUserPro_Load(sender, e);
        }
    }
}

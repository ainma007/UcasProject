using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using Ucas.Data;
using UcasProWindowsForm.Forms.ActivitiesForm;
using UcasProWindowsForm.Forms.AmountRecivedForms;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ExpensesForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Reports.ReportObj;
using System.Threading;
using UcasProWindowsForm.Reports.ReportCommand;
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
        public string ProjectName { get; set; }


        public string Progress { get; set; }
        DateTime date = DateTime.Now;
        private void fillData()
        {
            
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            InformationsClass.ProjID = TragetProject.ID;
            var ListData = ProjectProfileCmd.GetProjectData(InformationsClass.ProjID);
// Acount
            var TotalExpenses = ProjectExpensesCmd.GetTotalExpensesByProject(InformationsClass.ProjID).ToString();
            var TotalSalary = SalariesCmd.GetTotalSalaryByProject(InformationsClass.ProjID).ToString();
            var TotalAmountRecv = AmountsReceivedsCmd.GetTotalAmountsByProject(InformationsClass.ProjID).ToString();
            // GetSubActivety
            var q = SubActivityCmd.GetAllSubActivitiesByMonth(InformationsClass.ProjID);
            //
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

               

                foreach (var item in ListData)
                {

                    this.ProjectNameTextBox.Text = item.ProjectName;
                    this.DescTextBox.Text = item.ProjectDescription;
                    this.StartDateTextBox.Text = item.StartDate.ToString();
                    this.EndDateTextBox.Text = item.EndDate.ToString();
                    this.CostTextBox.Text = item.TotalCost.ToString();
                    this.CoinTextBox.Text = item.Coin.ToString();
                    InformationsClass.Coin = item.Coin;
                    this.Progress = item.progress.ToString();
                    this.StatustextBox.Text = item.Status;


                }
                ////AcounttextFill
               
            //    decimal val4 = decimal.Parse(AmountRecvTextBox.Text);

                 decimal Salary = decimal.Parse(TotalSalary);
                 decimal Expenses = decimal.Parse(TotalExpenses);
                 decimal AmountRecv = decimal.Parse(TotalAmountRecv);
                 decimal TotalExp = Salary + Expenses;

                ////
                 this.TotalExpensesTextBox.Text = TotalExp.ToString();
                 this.AmountRecvTextBox.Text = AmountRecv.ToString();
                 RemainingTextBox.Text = (AmountRecv - TotalExp).ToString();
                chart1.Series[0].Points.Clear();
                chart1.Titles.Clear();
                chart1.Series[0].Points.AddXY("موازنة المشروع", CostTextBox.Text);
                chart1.Series[0].Points.AddXY("اجمالي المبالغ المستلمة ", AmountRecv);
                chart1.Series[0].Points.AddXY("اجمالي المصاريف", TotalExp);
                chart1.Series[0].Points.AddXY("المتبقي من الرصيد", RemainingTextBox.Text);
                chart1.Titles.Add("مخطط موجز الحسابات للمشروع");
                chart1.Series[0].Points[0].Color = Color.Blue;
                chart1.Series[0].Points[1].Color = Color.YellowGreen;
                chart1.Series[0].Points[2].Color = Color.Red;
                chart1.Series[0].Points[3].Color = Color.YellowGreen;


                decimal Residual = 100 - decimal.Parse(Progress);
                chart2.Series[0].Points.Clear();

                chart2.Series[0].Points.AddXY("نسبة الانجاز", Progress);
                chart2.Series[0].Points.AddXY("المتبقى", Residual);
                chart2.Series[0].IsValueShownAsLabel = true;

                chart2.Series[0].Points[0].Color = Color.SkyBlue;
                chart2.Series[0].Points[1].Color = Color.Crimson;
                //// SubActivty 
                radGridView1.DataSource = q;


                label1.Text = InformationsClass.Coin;
                label2.Text = InformationsClass.Coin;
               
                label4.Text = InformationsClass.Coin;

                StatusLabel1.Text = "";
               
            });


        }
        private void FrmMainUserPro_Load(object sender, EventArgs e)
        {
            db = new ProjectProfile();
           
            
            Thread th = new Thread(fillData);
            th.Start();


           
           

            //
           
          
            //

           
            

           

         
           

            
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
            Operation.BeginOperation(this);
            FrmMangeAmount frm = new FrmMangeAmount();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void Expenseslbl_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
           
        }

        private void Expenses_Rbt_btn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            Reports.ReportCommand.ExpensessReportCmd cmd = new Reports.ReportCommand.ExpensessReportCmd();
            cmd.GetByProjectId(InformationsClass.ProjID);
            Operation.EndOperation(this);
        }

        private void Salary_rbt_btn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
             SalaryReportCmd cmd = new SalaryReportCmd();
            cmd.GetByProjectId(InformationsClass.ProjID);
            Operation.EndOperation(this);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmMainUserPro_Load(sender, e);
        }

        private void ProjectRbtBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            ProjectReportCmd cmd = new ProjectReportCmd();
           
            cmd.GetByProjectId(InformationsClass.ProjID);
            Operation.EndOperation(this);

        }

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            frmUserEditProject frm = new frmUserEditProject();
            frm.ProId = InformationsClass.ProjID;
            frm.ProjectNameTextBox .Text= ProjectNameTextBox.Text;
            frm.ProjectDescriptionTextBox.Text = DescTextBox.Text;
            frm.StartDateTimePicker.Text = StartDateTextBox.Text;
            frm.EndDateTimePicker.Text = EndDateTextBox.Text;
            frm.CoineDropDownList.Text = CoinTextBox.Text;
            frm.TotalCostTextBox.Text = CostTextBox.Text;
            frm.StatustextBox.Text = StatustextBox.Text;
            frm.ShowDialog();
        }

        private void ContractRbtBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            ContractReportCmd cmd = new ContractReportCmd();

            cmd.GetRptContractByProjectId(InformationsClass.ProjID);
            Operation.EndOperation(this);
        }

        private void AmountRecvRptBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            AmountRecvReportCmd cmd = new AmountRecvReportCmd();
            cmd.GetRptAmountRecvByProjectId(InformationsClass.ProjID);
            Operation.EndOperation(this);
        }
    }
}

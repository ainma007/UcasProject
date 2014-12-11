using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Forms.supplierForm;
using UcasProWindowsForm.Forms.UserSystemForm;



namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmAdmin : Telerik.WinControls.UI.RadForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
          
            RadMessageBox.SetThemeName("TelerikMetro");
           
        }

        Thread th;
        private void GetAllProject()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = ProjectProfileCmd.GetAllProjects();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                radGridView1.DataSource = q;
                StatusLabel1.Text = "";

            });
            th.Abort();

        } 
      
        private void FrmAdmin_Load(object sender, EventArgs e)


        {
            Operation.BeginOperation(this);
            th = new Thread(GetAllProject);
            th.Start();
            Operation.EndOperation(this);
        } 



        private void ProjectAddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this); 
            FrmAddProject AddPro = new FrmAddProject();
            AddPro.ShowDialog();
            Operation.EndOperation(this);
            FrmAdmin_Load(null, null);
        }

       

    

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddEmployee addempfrm = new FrmAddEmployee();
            addempfrm.ShowDialog();
            Operation.EndOperation(this);

        }

        private void ProjectMangBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmProjectManage ProMang = new FrmProjectManage();
            ProMang.ShowDialog();
            Operation.EndOperation(this);
            FrmAdmin_Load(null, null);

        }

        private void SuppAddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddsupplier addSup = new FrmAddsupplier();
            addSup.ShowDialog();
            Operation.EndOperation(this);

        }

        private void FinanAddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddTheTheDonors finadd = new FrmAddTheTheDonors();
            finadd.ShowDialog();
            Operation.EndOperation(this);

        }

     

        private void FrmAdmin_Activated(object sender, EventArgs e)
        {
         
        }

      

        private void FinanMangBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmManagementTheDonors finamang = new FrmManagementTheDonors();
            finamang.ShowDialog();
            Operation.EndOperation(this);

        }

        private void EmployeeMangBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmEmployeeMng empmang = new FrmEmployeeMng();
            empmang.ShowDialog();
            Operation.EndOperation(this);

        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmMainUserPro frm = new FrmMainUserPro();
            Ucas.Data.ProjectProfile db = (Ucas.Data.ProjectProfile)radGridView1.CurrentRow.DataBoundItem;
            frm.TragetProject = db;
            frm.ShowDialog();


            Operation.EndOperation(this);
            this.Hide();
            FrmAdmin_Load(null, null);
        }

     

        private void SupmanageBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmManagementSupplier MangSup = new FrmManagementSupplier();
            MangSup.ShowDialog();
            Operation.EndOperation(this);
        }

        private void UserMangBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            frmUserManage frm = new frmUserManage();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void AddUserToProjectBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            FrmAddUserToProject frm = new FrmAddUserToProject();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void UserProjectManageBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            FrmUserProjectManage frm = new FrmUserProjectManage();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void UserMangBtn_Click_1(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            frmUserManage FRM = new frmUserManage();
            FRM.ShowDialog();
            Operation.EndOperation(this);

        }

       
    }
}

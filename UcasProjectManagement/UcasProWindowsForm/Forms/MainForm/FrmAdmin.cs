using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Forms.supplierForm;
using UcasProWindowsForm.Forms.UserSystemForm;
using System.Data.Linq;
using System.Linq;
using System.Drawing;



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
        private void GetAllProjectAdmin()
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
        private void GetAllProjectUser()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = ProjectControlCmd.GetAllCurrentUserProjects();
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
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

     //       var  = ( from u in ProjectControlCmd.ge)
            switch (InformationsClass .XUserType)
            {


                case "مدير":
                       th = new Thread(GetAllProjectAdmin);
                       th.Start();
                       InformationsClass.Coordinator = 1;
                       InformationsClass.Accountant = 1;
                        GC.SuppressFinalize(th);
                        GC.Collect();
                        GC.WaitForFullGCComplete();
                        GC.WaitForPendingFinalizers(); 
                    break;

                case "منسق":

                    th = new Thread(GetAllProjectUser);
                       th.Start();
                    InformationsClass.Coordinator = 1;
                    InformationsClass.Accountant = 0;
                    toolStripDropDownButton1.Visible = false;
                    UserMangBtn.Visible = false;
                    UserProjectManageBtn.Visible = false;
                    AddUserToProjectBtn.Visible = false;
                    break;

                case "محاسب":

                    th = new Thread(GetAllProjectUser);
                    th.Start();
                    InformationsClass.Coordinator = 0;
                    InformationsClass.Accountant = 1;
                    toolStripDropDownButton1.Visible = false;
                    UserMangBtn.Visible = false;
                    UserProjectManageBtn.Visible = false;
                    AddUserToProjectBtn.Visible = false;
                    break;


                //case "غير فعال":


                //    break;
               
            }  
         
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
           
            FrmMainUserPro frm = new FrmMainUserPro();
            Ucas.Data.ProjectProfile db = (Ucas.Data.ProjectProfile)radGridView1.CurrentRow.DataBoundItem;
            if (InformationsClass.XUserType=="مدير")
            {
                Operation.BeginOperation(this);
                frm.TragetProject = db;
                this.Hide();
                frm.ShowDialog();
                Operation.EndOperation(this);
                return;
            }
            var c = db.ProjectControls.Where(p => p.ProjectID == db.ID).Take(1).SingleOrDefault();
            if (c.Status=="غير فعال")
            {
                // message not have permession
                Operation.EndOperation(this);
                RadMessageBox.Show("غير مصرح لك بالدخول");
               
                return;

            }
            else
            {
                Operation.BeginOperation(this);
                frm.TragetProject = db;
                this.Hide();
                frm.ShowDialog();
               
                Operation.EndOperation(this);
            }
           


        
           
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

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserNameEditBtn_Click(object sender, EventArgs e)
        {
            FrmEditUserNameAndPassword frm = new FrmEditUserNameAndPassword();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmAdmin_Load(null, null);
        }

        private void AboutBtn_ButtonClick(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.ShowDialog();

        }

       
    }
}

using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;
using System.Drawing;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmAddUserToProject : Telerik.WinControls.UI.RadForm
    {
        public FrmAddUserToProject()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void FillComboBox()
        {  ///GetActivityByProjectID
           ///
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.UserListComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.ProjectCombo.MultiColumnComboBoxElement.DropDownWidth = 300;


                //User
                this.UserListComboBox.AutoFilter = true;
                this.UserListComboBox.ValueMember = "ID";
                this.UserListComboBox.DisplayMember = "Employee.EmployeeName";

                ///
                //project
                this.ProjectCombo.AutoFilter = true;
                this.ProjectCombo.ValueMember = "ID";
                this.ProjectCombo.DisplayMember = "ProjectName";
            });

            var q = UsersCmd.GetAllUsersToProjects();
            var q1=ProjectProfileCmd.GetAllProjects();
            this.Invoke((MethodInvoker)delegate
            {
                //FillUser
                UserListComboBox.DataSource = q;
                this.UserListComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor empname = new FilterDescriptor("Employee.EmployeeName", FilterOperator.Contains, "");
                FilterDescriptor empNumber = new FilterDescriptor("Employee.EmployeejobNumber", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(empname);
                compositeFilter.FilterDescriptors.Add(empNumber);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.UserListComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);
              
                    ///
                //// fill ProjectCombo
            ProjectCombo.DataSource = q1;
            FilterDescriptor filter1 = new FilterDescriptor();
            filter1.PropertyName = this.ProjectCombo.DisplayMember;
            filter1.Operator = FilterOperator.Contains;
            this.ProjectCombo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);
           

            });
            Operation.EndOperation(this);
            th.Abort();


          
          
          
          
          
          




        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            try
            {
                ProjectControl tb = new ProjectControl
                {
                    UserID = int.Parse(UserListComboBox.SelectedValue.ToString()),
                    ProjectID = int.Parse(ProjectCombo.SelectedValue.ToString()),
                    Status = "فعال"
                };
                ProjectControlCmd.AddNewProControl(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk(OperationX.AddMessageDone, this);
                UserListComboBox.ResetText();
                ProjectCombo.ResetText();
                UserListComboBox.Focus();
                GC.SuppressFinalize(tb);
                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
            }
            catch (Xprema.XpremaException ex)
            {

                Operation.EndOperation(this);
                RadMessageBox.Show(ex.UserDescriptionArabic, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
          

        }

        private void FrmAddUserToProject_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            th = new Thread(FillComboBox);
            th.Start();
          
        }

        private void FrmAddUserToProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

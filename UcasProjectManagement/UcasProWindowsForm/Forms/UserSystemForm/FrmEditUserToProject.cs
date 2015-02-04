using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;
using System.Threading;
using System.Drawing;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmEditUserToProject : Telerik.WinControls.UI.RadForm
    {
        public FrmEditUserToProject()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
            
        }
        public int ProjectControlID { get; set; }
        Thread th;
        public Ucas.Data.ProjectControl TragetProjectControl { get; set; }
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
            var q1 = ProjectProfileCmd.GetAllProjects();
            this.Invoke((MethodInvoker)delegate
            {
                //FillUser
                UserListComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.UserListComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.UserListComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

                ///
                //// fill ProjectCombo
                ProjectCombo.DataSource = q1;
                FilterDescriptor filter1 = new FilterDescriptor();
                filter1.PropertyName = this.ProjectCombo.DisplayMember;
                filter1.Operator = FilterOperator.Contains;
                this.ProjectCombo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);

                ProjectControlID = TragetProjectControl.ID;
                UserListComboBox.Text = TragetProjectControl.UserTb.Employee.EmployeeName.ToString();
                ProjectCombo.Text = TragetProjectControl.ProjectProfile.ProjectName;
                StatusDropDownList.Text = TragetProjectControl.Status;
            });
            Operation.EndOperation(this);




            th.Abort();








        }
        private void FrmEditUserToProject_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            th = new Thread(FillComboBox);
            th.Start();
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {  
            #region "  CheckFillTextBox "


            if (UserListComboBox.Text == "")
            {

                UserListComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.UserListComboBox, "من فضلك اختر الموظف");
                UserListComboBox.Focus();

                return;
            }
            else
            {
                UserListComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (UserListComboBox.SelectedValue == null)
            {

                UserListComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.UserListComboBox, "من فضلك اختر الموظف");
                UserListComboBox.Focus();

                return;
            }
            else
            {
                UserListComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///

            if (ProjectCombo.Text == "")
            {

                ProjectCombo.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.ProjectCombo, "من فضلك اختر المشروع");
                UserListComboBox.Focus();

                return;
            }
            else
            {
                ProjectCombo.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (UserListComboBox.SelectedValue == null)
            {

                ProjectCombo.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.ProjectCombo, "من فضلك اختر المشروع");
                ProjectCombo.Focus();

                return;
            }
            else
            {
                ProjectCombo.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///
            #endregion
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
                

                ProjectControl tb = new ProjectControl
                {
                    ID = ProjectControlID,
                    UserID = int.Parse(UserListComboBox.SelectedValue.ToString()),
                    ProjectID = int.Parse(ProjectCombo.SelectedValue.ToString()),
                    Status = StatusDropDownList.Text
                };
                ProjectControlCmd.EditProControl(tb);
                Operation.EndOperation(this);
                RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK,RadMessageIcon.Info);
                GC.SuppressFinalize(th);
                GC.SuppressFinalize(tb);
                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Dispose();
            }
           

        }

        private void FrmEditUserToProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

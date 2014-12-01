using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmEditUserToProject : Telerik.WinControls.UI.RadForm
    {
        public FrmEditUserToProject()
        {
            InitializeComponent();
        }
        public int ProjectControlID { get; set; }
        public Ucas.Data.ProjectControl TragetProjectControl { get; set; }
      public  void FillComboBox()
        {

            ///GetActivityByProjectID
            this.UserListComboBox.AutoFilter = true;
            this.UserListComboBox.ValueMember = "ID";
            this.UserListComboBox.DisplayMember = "Employee.EmployeeName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.UserListComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.UserListComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            UserListComboBox.DataSource = UsersCmd.GetAllUsers();
          

           //// fill ProjectCombo
           this.ProjectCombo.AutoFilter = true;
           this.ProjectCombo.ValueMember = "ID";
           this.ProjectCombo.DisplayMember = "ProjectName";

           FilterDescriptor filter1 = new FilterDescriptor();
           filter1.PropertyName = this.ProjectCombo.DisplayMember;
           filter1.Operator = FilterOperator.Contains;
           this.ProjectCombo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);
           ProjectCombo.DataSource = ProjectProfileCmd.GetAllProjects();



        }
        private void FrmEditUserToProject_Load(object sender, EventArgs e)
        {
            FillComboBox();
            ProjectControlID = TragetProjectControl.ID;
            UserListComboBox.Text = TragetProjectControl.UserTb.Employee.EmployeeName.ToString();
            ProjectCombo.Text = TragetProjectControl.ProjectProfile.ProjectName;
            StatusDropDownList.Text = TragetProjectControl.Status;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {

                ProjectControl tb = new ProjectControl
                {
                    ID = ProjectControlID,
                    UserID = int.Parse(UserListComboBox.SelectedValue.ToString()),
                    ProjectID = int.Parse(ProjectCombo.SelectedValue.ToString()),
                    Status = StatusDropDownList.Text
                };
                ProjectControlCmd.EditProControl(tb);
                RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK,RadMessageIcon.Info);
                this.Close();
            }
           

        }
    }
}

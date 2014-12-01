using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmAddUserToProject : Telerik.WinControls.UI.RadForm
    {
        public FrmAddUserToProject()
        {
            InitializeComponent();
        }
        private void FillComboBox()
        {  ///GetActivityByProjectID
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
        private void AddBtn_Click(object sender, EventArgs e)
        {
            ProjectControl tb = new ProjectControl
            {
                UserID = int.Parse(UserListComboBox.SelectedValue.ToString()),
                ProjectID = int.Parse(ProjectCombo.SelectedValue.ToString()),
                Status="فعال"
            };
            ProjectControlCmd.AddNewProControl(tb);

        }

        private void FrmAddUserToProject_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }
    }
}

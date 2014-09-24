using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmUsersManage : Telerik.WinControls.UI.RadForm
    {
        public int XuserId { get; set; }
        public FrmUsersManage()
        {
            InitializeComponent();
        }
        UcasProEntities ucas = new UcasProEntities();

        private void PopulateComboxes()
        {
            ///GetAllEmployeeCombo
            this.EmployeeComboBox.AutoFilter = true;
            this.EmployeeComboBox.ValueMember = "ID";
            this.EmployeeComboBox.DisplayMember = "EmployeeName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.EmployeeComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EmployeeComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            EmployeeComboBox.DataSource = EmployeeCmd.GetAll();


            /////GetAllGroupComboBox
            this.GroupComboBox.AutoFilter = true;
            this.GroupComboBox.ValueMember = "ID";
            this.GroupComboBox.DisplayMember = "GroupName";

            FilterDescriptor filter2 = new FilterDescriptor();
            filter2.PropertyName = this.GroupComboBox.DisplayMember;
            filter2.Operator = FilterOperator.Contains;
            this.GroupComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter2);
            GroupComboBox.DataSource = GroupCmd.GetAllGroups();

            ///GetAllProjectCombo

            this.ProjectsComboBox.AutoFilter = true;
            this.ProjectsComboBox.ValueMember = "ID";
            this.ProjectsComboBox.DisplayMember = "ProjectName";

            FilterDescriptor filter3 = new FilterDescriptor();
            filter3.PropertyName = this.ProjectsComboBox.DisplayMember;
            filter3.Operator = FilterOperator.Contains;
            this.ProjectsComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter3);
            ProjectsComboBox.DataSource = ProjectProfileCmd.GetAllProjects();
        }



        private void FrmUsersManage_Load(object sender, EventArgs e)
        {

            usersTbBindingSource.DataSource = UsersCmd.GetUserTb();
            PopulateComboxes();
        //  usersTbBindingSource.DataSource = UsersCmd.GetAllUsers();

        }


        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {

            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.XuserId = int.Parse((currentRow.Cells[0].Value.ToString()));
                this.EmployeeComboBox.Text = (currentRow.Cells[1].Value.ToString());
                this.UserNameTextBox.Text = (currentRow.Cells[2].Value.ToString());
                this.PasswordTextBox.Text = (currentRow.Cells[3].Value.ToString());
                this.GroupComboBox.Text = (currentRow.Cells[4].Value.ToString());

              



            }

        }

        private void selectProjcetUser()
        {
            var q = ProjectControlCmd.GetprojectContrl(XuserId);

          try
          {
              radGroupBox2.Enabled = true;  
		       ProjectsComboBox.SelectedValue = q.ProjectID;
                StatusDropDownList.Text = q.Status;
	}

	catch (Exception)
	{
        radGroupBox2.Enabled = false;
        return;
	}
            
               
              
            
            
         

        }
        private void UserGridView_DoubleClick(object sender, EventArgs e)
        {
            UpdatePanelInfo(this.UserGridView.CurrentRow, 5);
            selectProjcetUser();

        }
    }
}

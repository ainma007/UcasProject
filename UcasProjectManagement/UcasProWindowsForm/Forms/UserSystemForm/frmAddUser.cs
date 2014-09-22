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
    public partial class frmAddUser : Telerik.WinControls.UI.RadForm
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        #region " Load All Groups & Employee & Project If It Exiest "
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

         
            employeeBindingSource.DataSource = EmployeeCmd.GetAll();
            
            
            /////GetAllGroupComboBox
            this.GroupComboBox.AutoFilter = true;
            this.GroupComboBox.ValueMember = "ID";
            this.GroupComboBox.DisplayMember = "GroupName";

            FilterDescriptor filter2 = new FilterDescriptor();
            filter2.PropertyName = this.GroupComboBox.DisplayMember;
            filter2.Operator = FilterOperator.Contains;
            this.GroupComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter2);
            groupsTbBindingSource.DataSource = GroupCmd.GetAllGroups();

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
        #endregion 

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            PopulateComboxes();
            GroupComboBox.ResetText();
            EmployeeComboBox.ResetText();

        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("" + EmployeeComboBox.SelectedValue.ToString());
            //MessageBox.Show("" + GroupComboBox.SelectedValue.ToString());
            try
            {
                int CheckUserExiest = UsersCmd.GetCurrentUserIDByNameAndPass(UesrnameTextBox.Text, PaswwordTextBox.Text);
                if (CheckUserExiest != 0)
                {
                    MessageBox.Show("Exiested ...  Save Process  Was Canceled");
                    return;
                }
            }
            catch (Exception)
            {
                
                           UsersTb tb = new UsersTb()
            {

                EmployeeID=int.Parse( EmployeeComboBox.SelectedValue.ToString()),
                UserName = UesrnameTextBox.Text,
                Password=PaswwordTextBox.Text,
                GroupID=int.Parse( GroupComboBox.SelectedValue.ToString())

            };

            UsersCmd.AddUser(tb);
            int xlast = UsersCmd.GetLastUserID();
            //===========================================
            // Add Project 
           
            if (ActivecheckBox.CheckState == CheckState.Checked)
            {
                ProjectControl pTb = new ProjectControl()
                {

                    UserID = xlast,
                    ProjectID = int.Parse(ProjectsComboBox.SelectedValue.ToString()),

                    Status = "فعال"

                };
                ProjectControlCmd.AddNewProControl(pTb);
                //==========================================
                MessageBox.Show("Done");


            }
            }

          
           
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActivecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ActivecheckBox.CheckState == CheckState.Checked)
                {
                    ProjectsComboBox.Enabled = true;
                }

                else
                {

                    ProjectsComboBox.Enabled = false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

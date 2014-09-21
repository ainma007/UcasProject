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
namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class frmAddUser : Telerik.WinControls.UI.RadForm
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        #region " Load All Groups & Employee If It Exiest "
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
            MessageBox.Show("" + EmployeeComboBox.SelectedValue.ToString());
            MessageBox.Show("" + GroupComboBox.SelectedValue.ToString());
           
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

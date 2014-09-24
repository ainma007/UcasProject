using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmUserManagment : Telerik.WinControls.UI.RadForm
    {
        public FrmUserManagment()
        {
            InitializeComponent();
        }

        private void FillCombo()
        
        {

            // Create Sourrce Here
            string[] s1 = { "فعال", " غير فعال" };

            //--- Get Coloumn From Grid
            GridViewComboBoxColumn Col2 = (GridViewComboBoxColumn)projectUserGridView.Columns["Status"];
            Col2.DataSource = s1;
            ///// filemployee

            EmployeebindingSource.DataSource = EmployeeCmd.GetAll();
            GridViewComboBoxColumn EmployeeCol = (GridViewComboBoxColumn)radGridView1.Columns["Emloyee"];
            EmployeeCol.DataSource = EmployeebindingSource;
            EmployeeCol.DisplayMember = "EmployeeName";
            EmployeeCol.ValueMember = "ID";
          //  EmployeeCol.FieldName = "OrderID";
           //  EmployeeCol.HeaderText = "EmployeeName";
         
            ////

            bindingSource1.DataSource = ProjectProfileCmd.GetAllProjects();
            GridViewComboBoxColumn procol = (GridViewComboBoxColumn)radGridView1.Columns["PRoID"];
            procol.DataSource = bindingSource1;
            procol.DisplayMember = "ProjectName";
            procol.ValueMember = "ID";

        }
        private void FrmUserManagment_Load(object sender, EventArgs e)
        {
            projectUserGridView.DataSource = UsersCmd.GetUserTb();
            FillCombo();
            radGridView1.DataSource = UsersCmd.GetAllUsers();

            
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
        }
    }
}

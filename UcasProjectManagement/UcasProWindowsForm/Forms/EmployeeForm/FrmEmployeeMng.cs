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

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmEmployeeMng : Telerik.WinControls.UI.RadForm
    {
        public FrmEmployeeMng()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public void GetAllEmployee()
        {
            employeeBindingSource.DataSource = EmployeeCmd.GetAll();
        }

        private void FillCombo()
        {


            // Create Sourrce Here
            string[] s1 = { "ذكر", " أنثى" };

            //--- Get Coloumn From Grid
            GridViewComboBoxColumn Col2 = (GridViewComboBoxColumn)EmployeeGridView.Columns["EmployeeGender"];
            Col2.DataSource = s1;
        }

       
        private void FrmEmployeeMng_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
            FillCombo();
            
        }

        private void EmployeeGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            
          
           

        }

        private void EmployeeGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = EmployeeGridView.CurrentColumn.Index;
            if (col == 8)
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEmployeeEdit frm = new FrmEmployeeEdit();
                Ucas.Data.Employee emp = (Ucas.Data.Employee)EmployeeGridView.CurrentRow.DataBoundItem;
                frm.TragetEmployee = emp;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;     
              
              
            }

            if (col == 9)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Employee emp = employeeBindingSource.Current as Employee;
                    EmployeeCmd.DeleteEmployee(emp.ID);
                    GetAllEmployee();
                    this.Cursor = Cursors.Default;   
                    
                }


            }
        }

    

       

   
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddEmployee add = new FrmAddEmployee();
            add.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            GetAllEmployee();
            this.Cursor = Cursors.Default;
        }

        private void FrmEmployeeMng_Activated(object sender, EventArgs e)
        {
            
        }
       

        private void EmployeeGridView_Click(object sender, EventArgs e)
        {
}

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Reports.ReportCommand.EmployeeReportCmd cmd = new Reports.ReportCommand.EmployeeReportCmd();
            cmd.GetAllEmployee();
            this.Cursor = Cursors.Default;

        }
}
       
    }


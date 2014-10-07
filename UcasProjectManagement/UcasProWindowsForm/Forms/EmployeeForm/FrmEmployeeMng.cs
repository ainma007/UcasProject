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

        private void LockGrid()
        {
            for (int i = 0; i <= EmployeeGridView.Rows.Count - 1; i++)
            {
                EmployeeGridView.Rows[i].Cells[0].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[1].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[2].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[3].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[4].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[5].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[6].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[7].ReadOnly = true;
                EmployeeGridView.Rows[i].Cells[8].ReadOnly = true;


            }

        }
        private void FrmEmployeeMng_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
            FillCombo();
            LockGrid();
        }

        private void EmployeeGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                EmployeeGridView.Rows[e.RowIndex].Cells[0].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[5].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[6].ReadOnly = false;
                EmployeeGridView.Rows[e.RowIndex].Cells[7].ReadOnly = false;
            }
            catch (Exception)
            {

                return;
            }
          
           

        }

        private void EmployeeGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = EmployeeGridView.CurrentColumn.Index;
            if (col == 8)
            {
                if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Employee emp = employeeBindingSource.Current as Employee;
                    EmployeeCmd.EditEmployee(emp);
                    GetAllEmployee();
                    LockGrid();
                }
                else
                {

                    GetAllEmployee();

                    LockGrid();
                }
            }

            if (col == 9)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Employee emp = employeeBindingSource.Current as Employee;
                    EmployeeCmd.DeleteEmployee(emp.ID);
                    GetAllEmployee();
                    LockGrid();
                }


            }
        }

    

       

   
        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee add = new FrmAddEmployee();
            add.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetAllEmployee();
        }

        private void FrmEmployeeMng_Activated(object sender, EventArgs e)
        {
            
        }
       

        private void EmployeeGridView_Click(object sender, EventArgs e)
        {
}
}
       
    }


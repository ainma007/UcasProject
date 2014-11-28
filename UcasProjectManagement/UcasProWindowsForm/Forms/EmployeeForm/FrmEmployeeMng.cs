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
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";

            });
            Operation.BeginOperation(this);
            try
            {
                Application.DoEvents();
                employeeBindingSource.DataSource = EmployeeCmd.GetAll();


                Application.DoEvents();
            }

            catch (System.InvalidOperationException ex)
            {

                Application.DoEvents();
                employeeBindingSource.DataSource = EmployeeCmd.GetAll();
                Application.DoEvents();
            }

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = " ";

            });
          
        }

        

       
        private void FrmEmployeeMng_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
           
            
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
            
            FrmAddEmployee add = new FrmAddEmployee();
            add.ShowDialog();
          
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

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void radRibbonBar1_Click_1(object sender, EventArgs e)
        {

        }
}
       
    }


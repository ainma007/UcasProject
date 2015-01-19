using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportCommand;
using UcasProWindowsForm.Reports.ReportObj;
using System.Drawing;

namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmManagementSupplier : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementSupplier()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void GetAllsupplier()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = SuppliersCmd.GetAll();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                supplierGridView.DataSource = q;
                StatusLabel1.Text = "";

            });
            th.Abort();
        }

    

      
     

        private void FrmManagementSupplier_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(GetAllsupplier);
            th.Start();

          
           
            
        }
        
        

       

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
          try{  
        var col = supplierGridView.CurrentColumn.Index;
        if (col == 7)
        {
            Operation.BeginOperation(this);
            

            FrmEditsupplier frm = new FrmEditsupplier();
            Ucas.Data.Supplier db = (Ucas.Data.Supplier)supplierGridView.CurrentRow.DataBoundItem;
            frm.TragetDSupplier = db;
            frm.ShowDialog();
            Operation.EndOperation(this);
            FrmManagementSupplier_Load(null, null);
           
        }
        if (col == 8) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        Operation.BeginOperation(this);
                        if (SuppliersCmd.DeleteSupplier(int.Parse(supplierGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                            Operation.EndOperation(this);
                            FrmManagementSupplier_Load(null, null);
                            Operation.ShowToustOk(OperationX.DeletedMessage, this);

                          
                        }
                        else
                        {
                            Operation.EndOperation(this);
                            RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                        }
                       
                     
                    }

            }
            }
           
         catch (Exception)
            {

                return;
            }
        }

     

      

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
           

            FrmAddsupplier frm = new FrmAddsupplier();
            frm.ShowDialog();
            Operation.EndOperation(this);
            FrmManagementSupplier_Load(null, null);
        }

        private void ReportviewBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            List<SupplierReportObj> ls = new List<SupplierReportObj>();
            int counter = 0;
            //    ls.Add(new SalaryReportObj() {  SalarysID = counter});
            foreach (GridViewRowInfo item in supplierGridView.ChildRows)
            {
                counter++;
                ls.Add(new SupplierReportObj()
                {
                    SupplierID = counter,
                    SupplierName = item.Cells["Name"].Value.ToString(),
                    Address = item.Cells["Adderss"].Value.ToString(),
                    SuppliersNatural = item.Cells["SuppliersNatural"].Value.ToString(),
                    Faxnumber = item.Cells["Fax"].Value.ToString(),
                    Email = item.Cells["Email"].Value.ToString(),
                    PhoneNumber = item.Cells["PhoneNumber"].Value.ToString(),
                  

                });
            }
            Reports.ReportCommand.SupplierReportCmd cmd = new Reports.ReportCommand.SupplierReportCmd();
            cmd.ShowSuppReportByGrid(ls);
            Operation.EndOperation(this);
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FrmManagementSupplier_Load(null, null);
            this.Cursor = Cursors.Default;

        }

        private void FrmManagementSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

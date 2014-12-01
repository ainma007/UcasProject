using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportCommand;

namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmManagementSupplier : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementSupplier()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        UcasProEntities cmd = new UcasProEntities();
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
            
        }

    

      
     

        private void FrmManagementSupplier_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(GetAllsupplier);
            th.Start();

           // GetAllsupplier();
           
            
        }
        
        

       

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
          try{  
        var col = supplierGridView.CurrentColumn.Index;
        if (col == 7)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEditsupplier frm = new FrmEditsupplier();
            Ucas.Data.Supplier db = (Ucas.Data.Supplier)supplierGridView.CurrentRow.DataBoundItem;
            frm.TragetDSupplier = db;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
           
        }
        if (col == 8) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        SuppliersCmd.DeleteSupplier(int.Parse(supplierGridView.CurrentRow.Cells[0].Value.ToString()));
                        GetAllsupplier();
                        this.Cursor = Cursors.Default;
                     
                    }

            }
            }
           
         catch (Exception)
            {

                return;
            }
        }

     

        private void MasterTemplate_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
          
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddsupplier frm = new FrmAddsupplier();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void ReportviewBtn_Click(object sender, EventArgs e)
        {
            SupplierReportCmd cmd = new SupplierReportCmd();
            cmd.GetAllSupplier();
        }
    }
}

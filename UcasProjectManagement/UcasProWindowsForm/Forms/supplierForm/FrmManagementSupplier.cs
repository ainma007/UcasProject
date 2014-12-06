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
            Operation.BeginOperation(this);
            

            FrmEditsupplier frm = new FrmEditsupplier();
            Ucas.Data.Supplier db = (Ucas.Data.Supplier)supplierGridView.CurrentRow.DataBoundItem;
            frm.TragetDSupplier = db;
            frm.ShowDialog();
            Operation.EndOperation(this);
           
        }
        if (col == 8) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        Operation.BeginOperation(this);
                        if (SuppliersCmd.DeleteSupplier(int.Parse(supplierGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                            Operation.EndOperation(this);
                            Operation.ShowToustOk(OperationX.DeletedMessage, this);

                            FrmManagementSupplier_Load(sender, e);
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
        }

        private void ReportviewBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            
            SupplierReportCmd cmd = new SupplierReportCmd();
            cmd.GetAllSupplier();
            Operation.EndOperation(this);
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            FrmManagementSupplier_Load(sender, e);
        }
    }
}

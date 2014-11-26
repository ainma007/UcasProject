using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            radGridView1.DataSource = SuppliersCmd.GetAll();
        }

    

      
     

        private void FrmManagementSupplier_Load(object sender, EventArgs e)
        {
            GetAllsupplier();
           
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        
        

       

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
          try{  
        var col = radGridView1.CurrentColumn.Index;
        if (col == 7)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEditsupplier frm = new FrmEditsupplier();
            Ucas.Data.Supplier db = (Ucas.Data.Supplier)radGridView1.CurrentRow.DataBoundItem;
            frm.TragetDSupplier = db;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
           
        }
        if (col == 8) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        SuppliersCmd.DeleteSupplier(int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString()));
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

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

namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmManagementSupplier : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementSupplier()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Light");
        }
        UcasProEntities cmd = new UcasProEntities();
        private void GetAllsupplier()
        {

            supplierBindingSource.DataSource = SuppliersCmd.GetAll();
        }

    private  void LockGrid()
        {
            for (int i = 0; i <= radGridView1.Rows.Count - 1; i++)
            {
                radGridView1.Rows[i].Cells[0].ReadOnly = true;
                radGridView1.Rows[i].Cells[1].ReadOnly = true;
                radGridView1.Rows[i].Cells[2].ReadOnly = true;
                radGridView1.Rows[i].Cells[3].ReadOnly = true;
                radGridView1.Rows[i].Cells[4].ReadOnly = true;
                radGridView1.Rows[i].Cells[5].ReadOnly = true;
                radGridView1.Rows[i].Cells[6].ReadOnly = true;
                radGridView1.Rows[i].Cells[7].ReadOnly = true;
              
              


            }

        }
     

        private void FrmManagementSupplier_Load(object sender, EventArgs e)
        {
            GetAllsupplier();
            LockGrid();
        }
        
        

       

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
          try{  
        var col = radGridView1.CurrentColumn.Index;
        if (col == 8)
        {
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Supplier sup = supplierBindingSource.Current as Supplier;
                SuppliersCmd.EditSupplier(sup);
                GetAllsupplier();
                LockGrid();
            }
            else
            {

                GetAllsupplier();
                LockGrid();
            }
        }
        if (col == 9) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        Supplier sup = supplierBindingSource.Current as Supplier;
                        SuppliersCmd.DeleteSupplier(sup.ID);
                        GetAllsupplier();
                        LockGrid();
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
            radGridView1.Rows[e.RowIndex].Cells[0].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[1].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[3].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[4].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[5].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[6].ReadOnly = false;
            radGridView1.Rows[e.RowIndex].Cells[7].ReadOnly = false;
            
        }
    }
}

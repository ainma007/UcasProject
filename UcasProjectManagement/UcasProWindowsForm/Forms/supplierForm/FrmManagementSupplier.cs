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
        }
        UcasProEntities cmd = new UcasProEntities();
        private void GetAllsupplier()
        {

            supplierBindingSource.DataSource = SuppliersCmd.GetAll();
        }
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void FrmManagementSupplier_Load(object sender, EventArgs e)
        {
            GetAllsupplier();
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
         
           
        }

        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView1.Columns[e.ColumnIndex].Index == radGridView1.Columns[9].Index)
                {
                    if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                    {
                        Supplier sup = supplierBindingSource.Current as Supplier;
                        SuppliersCmd.EditSupplier(sup);
                        GetAllsupplier();
                    }
                    else
                    {

                        GetAllsupplier();
                    }


                }

                if (radGridView1.Columns[e.ColumnIndex].Index == radGridView1.Columns[10].Index)
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                    {
                        Supplier sup = supplierBindingSource.Current as Supplier;
                        SuppliersCmd.DeleteSupplier(sup.ID);
                        GetAllsupplier();
                    }

            }
            catch (Exception)
            {

                return;
            }
            
        }
    }
}

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
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void FrmManagementSupplier_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = SuppliersCmd.GetAll();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            supplierBindingSource.EndEdit();
            cmd.SaveChanges();
           
        }
    }
}

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
    public partial class FrmManagementFinanciers : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementFinanciers()
        {
            InitializeComponent();
        }

        private void GetAllFinanciers()
        {

            thefinancierBindingSource.DataSource = FinanciersCmd.GetAllFinanciers();
        }
        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
            GetAllFinanciers();
        }
    }
}

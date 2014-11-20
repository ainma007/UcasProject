using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmEmployeeEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmEmployeeEdit()
        {
            InitializeComponent();
        }
        public Ucas.Data.Employee TragetEmployee { get; set; }
        private void FrmEmployeeEdit_Load(object sender, EventArgs e)
        {

        }
    }
}

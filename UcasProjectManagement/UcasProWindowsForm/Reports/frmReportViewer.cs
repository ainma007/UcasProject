﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UcasProWindowsForm.Reports
{
    public partial class frmReportViewer : Telerik.WinControls.UI.RadForm
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
             this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

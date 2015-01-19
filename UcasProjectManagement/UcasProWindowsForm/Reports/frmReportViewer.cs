using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using System.Drawing;

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
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            Operation.BeginOperation(this);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

           
             this.reportViewer1.RefreshReport();
             Operation.EndOperation(this);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

        }

        private void frmReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.SuppressFinalize(reportViewer1);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            
        }
    }
}

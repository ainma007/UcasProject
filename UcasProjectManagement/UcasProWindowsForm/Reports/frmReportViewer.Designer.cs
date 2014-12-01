namespace UcasProWindowsForm.Reports
{
    partial class frmReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalaryReportObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DonaorReportObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierReportObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExpensessReportObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectReportObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryReportObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonaorReportObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierReportObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensessReportObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectReportObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DonaorReportObjBindingSource
            // 
            this.DonaorReportObjBindingSource.DataSource = typeof(UcasProWindowsForm.Reports.ReportObj.DonaorReportObj);
            // 
            // SupplierReportObjBindingSource
            // 
            this.SupplierReportObjBindingSource.DataSource = typeof(UcasProWindowsForm.Reports.ReportObj.SupplierReportObj);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProjectDataSet";
            reportDataSource1.Value = this.ProjectReportObjBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 511);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ExpensessReportObjBindingSource
            // 
            this.ExpensessReportObjBindingSource.DataSource = typeof(UcasProWindowsForm.Reports.ReportObj.ExpensessReportObj);
            // 
            // ProjectReportObjBindingSource
            // 
            this.ProjectReportObjBindingSource.DataSource = typeof(UcasProWindowsForm.Reports.ReportObj.ProjectReportObj);
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportViewer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmReportViewer";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryReportObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonaorReportObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierReportObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensessReportObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectReportObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ExpensessReportObjBindingSource;
        private System.Windows.Forms.BindingSource SalaryReportObjBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SupplierReportObjBindingSource;
        private System.Windows.Forms.BindingSource DonaorReportObjBindingSource;
        private System.Windows.Forms.BindingSource ProjectReportObjBindingSource;

    }
}

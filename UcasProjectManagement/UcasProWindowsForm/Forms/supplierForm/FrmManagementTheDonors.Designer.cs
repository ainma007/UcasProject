namespace UcasProWindowsForm.Forms.supplierForm
{
    partial class FrmManagementTheDonors
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagementTheDonors));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DonersGridView = new Telerik.WinControls.UI.RadGridView();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DonersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonersGridView.MasterTemplate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DonersGridView
            // 
            this.DonersGridView.AutoSizeRows = true;
            this.DonersGridView.BackColor = System.Drawing.SystemColors.Control;
            this.DonersGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DonersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonersGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DonersGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DonersGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DonersGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // DonersGridView
            // 
            this.DonersGridView.MasterTemplate.AllowAddNewRow = false;
            this.DonersGridView.MasterTemplate.AllowSearchRow = true;
            this.DonersGridView.MasterTemplate.AutoGenerateColumns = false;
            this.DonersGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "الرقم";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn2.Width = 60;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Name";
            gridViewTextBoxColumn7.HeaderText = "الجهة المانحة";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Name";
            gridViewTextBoxColumn7.Width = 175;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "agentName";
            gridViewTextBoxColumn8.HeaderText = "اسم الوكيل";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "agentName";
            gridViewTextBoxColumn8.Width = 165;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "PhoneNumber";
            gridViewTextBoxColumn9.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "PhoneNumber";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 154;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Fax";
            gridViewTextBoxColumn10.HeaderText = "الفاكس";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Fax";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 167;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Email";
            gridViewTextBoxColumn11.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "Email";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 171;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "Adderss";
            gridViewTextBoxColumn12.HeaderText = "العنوان";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "Adderss";
            gridViewTextBoxColumn12.Width = 165;
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderText = "حفظ";
            gridViewCommandColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn3.Image")));
            gridViewCommandColumn3.MaxWidth = 45;
            gridViewCommandColumn3.MinWidth = 45;
            gridViewCommandColumn3.Name = "EditBtn";
            gridViewCommandColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn3.Width = 45;
            gridViewCommandColumn4.EnableExpressionEditor = false;
            gridViewCommandColumn4.HeaderText = "حذف";
            gridViewCommandColumn4.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn4.Image")));
            gridViewCommandColumn4.MaxWidth = 45;
            gridViewCommandColumn4.MinWidth = 45;
            gridViewCommandColumn4.Name = "DelteBtn";
            gridViewCommandColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn4.Width = 45;
            this.DonersGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewCommandColumn3,
            gridViewCommandColumn4});
            this.DonersGridView.MasterTemplate.EnableFiltering = true;
            this.DonersGridView.MasterTemplate.EnablePaging = true;
            this.DonersGridView.MasterTemplate.MultiSelect = true;
            this.DonersGridView.Name = "DonersGridView";
            this.DonersGridView.ReadOnly = true;
            this.DonersGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DonersGridView.ShowGroupPanel = false;
            this.DonersGridView.Size = new System.Drawing.Size(1100, 744);
            this.DonersGridView.TabIndex = 3;
            this.DonersGridView.Text = "radGridView1";
            this.DonersGridView.ThemeName = "TelerikMetro";
            this.DonersGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DonersGridView_CommandCellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2,
            this.PrintBtn,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1104, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::UcasProWindowsForm.Properties.Resources.Add1;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(99, 36);
            this.AddBtn.Text = "اضافة ممول";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::UcasProWindowsForm.Properties.Resources.Refrech;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(117, 36);
            this.RefreshBtn.Text = "تحديث السجلات";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Image = global::UcasProWindowsForm.Properties.Resources.Print;
            this.PrintBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PrintBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(99, 36);
            this.PrintBtn.Text = "طباعة تقرير";
            this.PrintBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 803);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1104, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.StatusLabel1.Text = "-";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.DonersGridView);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "سجلات الممولين";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 39);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1104, 764);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.Text = "سجلات الممولين";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // FrmManagementTheDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 825);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManagementTheDonors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManagementFinanciers";
            this.ThemeName = "TelerikMetro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManagementFinanciers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonersGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonersGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DonersGridView;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}

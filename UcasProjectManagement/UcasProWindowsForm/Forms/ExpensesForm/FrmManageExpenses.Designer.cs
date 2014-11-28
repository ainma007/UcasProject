namespace UcasProWindowsForm.Forms.ExpensesForm
{
    partial class FrmManageExpenses
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageExpenses));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpensesGridView = new Telerik.WinControls.UI.RadGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGridView.MasterTemplate)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.PrintBtn,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1238, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::UcasProWindowsForm.Properties.Resources.Add1;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 36);
            this.AddBtn.Text = "اضافة سجل";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::UcasProWindowsForm.Properties.Resources.Refrech;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(117, 36);
            this.toolStripButton2.Text = "تحديث السجلات";
            this.toolStripButton2.Click += new System.EventHandler(this.RefrechBtn_Click);
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // ExpensesGridView
            // 
            this.ExpensesGridView.BackColor = System.Drawing.Color.White;
            this.ExpensesGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpensesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensesGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpensesGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExpensesGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpensesGridView.Location = new System.Drawing.Point(0, 39);
            // 
            // ExpensesGridView
            // 
            this.ExpensesGridView.MasterTemplate.AllowAddNewRow = false;
            this.ExpensesGridView.MasterTemplate.AllowColumnReorder = false;
            this.ExpensesGridView.MasterTemplate.AllowSearchRow = true;
            this.ExpensesGridView.MasterTemplate.AutoGenerateColumns = false;
            this.ExpensesGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "الرقم";
            gridViewTextBoxColumn1.Name = "Num";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 110;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 62;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ExpensesName";
            gridViewTextBoxColumn2.HeaderText = "المصروف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ExpensesName";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 148;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DateofProcess";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ العملية";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DateofProcess";
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 148;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "BillNumber";
            gridViewTextBoxColumn3.HeaderText = "رقم الفاتورة";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "BillNumber";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 148;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "RequiarAmount";
            gridViewDecimalColumn2.HeaderText = "المبلغ";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "RequiarAmount";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.Width = 148;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CashingNumber";
            gridViewTextBoxColumn4.HeaderText = "رقم سند الصرف";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "CashingNumber";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 148;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Supplier.Name";
            gridViewTextBoxColumn5.HeaderText = "المورد";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "SupplierName";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 120;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ProjectSubActivity.SubActivityName";
            gridViewTextBoxColumn6.HeaderText = "تابع لنشاط";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ProjectSubActivity";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 167;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "تعديل";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gridViewCommandColumn1.MaxWidth = 45;
            gridViewCommandColumn1.MinWidth = 45;
            gridViewCommandColumn1.Name = "editColm";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gridViewCommandColumn2.MaxWidth = 45;
            gridViewCommandColumn2.MinWidth = 45;
            gridViewCommandColumn2.Name = "DelColm";
            gridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn2.Width = 45;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ProjectProfile.ProjectName";
            gridViewDecimalColumn3.HeaderText = "ProjectName";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "ProjectName";
            gridViewDecimalColumn3.Width = 69;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "ProjectProfile.Coin";
            gridViewDecimalColumn4.HeaderText = "Coin";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Coin";
            gridViewDecimalColumn4.Width = 62;
            this.ExpensesGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4});
            this.ExpensesGridView.Name = "ExpensesGridView";
            this.ExpensesGridView.ReadOnly = true;
            this.ExpensesGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExpensesGridView.Size = new System.Drawing.Size(1238, 539);
            this.ExpensesGridView.TabIndex = 7;
            this.ExpensesGridView.Text = "radGridView1";
            this.ExpensesGridView.ThemeName = "TelerikMetro";
            this.ExpensesGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.ExpensesGridView_CommandCellClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1238, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // FrmManageExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 578);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ExpensesGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageExpenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المصروفات";
            this.ThemeName = "TelerikMetro";
            this.Activated += new System.EventHandler(this.FrmManageExpenses_Activated);
            this.Load += new System.EventHandler(this.FrmManageExpenses_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Telerik.WinControls.UI.RadGridView ExpensesGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

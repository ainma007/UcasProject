namespace UcasProWindowsForm.Forms.ExpensesForm
{
    partial class FrmSalariesManage
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalariesManage));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SalaryGridView = new Telerik.WinControls.UI.RadGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView.MasterTemplate)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1114, 39);
            this.toolStrip1.TabIndex = 5;
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.PrintBtn.Click += new System.EventHandler(this.PrintDraftBtn_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1114, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.StatusLabel1.Text = "-";
            // 
            // SalaryGridView
            // 
            this.SalaryGridView.BackColor = System.Drawing.Color.White;
            this.SalaryGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalaryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalaryGridView.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SalaryGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SalaryGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SalaryGridView.Location = new System.Drawing.Point(0, 39);
            // 
            // SalaryGridView
            // 
            this.SalaryGridView.MasterTemplate.AllowAddNewRow = false;
            this.SalaryGridView.MasterTemplate.AllowColumnReorder = false;
            this.SalaryGridView.MasterTemplate.AllowDragToGroup = false;
            this.SalaryGridView.MasterTemplate.AutoGenerateColumns = false;
            this.SalaryGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 43;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Contract.Employee.EmployeejobNumber";
            gridViewTextBoxColumn1.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn1.Name = "EmployeejobNumber";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 158;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Contract.Employee.EmployeeName";
            gridViewDecimalColumn2.HeaderText = "اسم الموظف";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "EmployeeName";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewDecimalColumn2.Width = 408;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Amount";
            gridViewDecimalColumn3.HeaderText = "الراتب";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Amount";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.Width = 177;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "IssueDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ الاصدار";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "IssueDate";
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 136;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "Formonth";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "مستحق لشهر";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Formonth";
            gridViewDateTimeColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn2.Width = 131;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "ProjectProfile.Coin";
            gridViewDecimalColumn4.HeaderText = "Coin";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Coin";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ProjectProfile.ProjectName";
            gridViewTextBoxColumn2.HeaderText = "المشروع";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "ProjectName";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "تعديل";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.MaxWidth = 45;
            gridViewCommandColumn1.MinWidth = 45;
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.MaxWidth = 45;
            gridViewCommandColumn2.MinWidth = 45;
            gridViewCommandColumn2.Name = "DeleteCol";
            gridViewCommandColumn2.Width = 45;
            this.SalaryGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.SalaryGridView.MasterTemplate.EnableFiltering = true;
            this.SalaryGridView.MasterTemplate.EnablePaging = true;
            this.SalaryGridView.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            sortDescriptor1.PropertyName = "ID";
            this.SalaryGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.SalaryGridView.Name = "SalaryGridView";
            this.SalaryGridView.ReadOnly = true;
            this.SalaryGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalaryGridView.Size = new System.Drawing.Size(1114, 486);
            this.SalaryGridView.TabIndex = 8;
            this.SalaryGridView.Text = "SalaryGridView";
            this.SalaryGridView.ThemeName = "TelerikMetro";
            this.SalaryGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.SalaryGridView_CommandCellClick);
            // 
            // FrmSalariesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 547);
            this.Controls.Add(this.SalaryGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmSalariesManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الرواتب";
            this.ThemeName = "TelerikMetro";
            this.Activated += new System.EventHandler(this.FrmSalariesManage_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSalariesManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmSalariesManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private Telerik.WinControls.UI.RadGridView SalaryGridView;
    }
}

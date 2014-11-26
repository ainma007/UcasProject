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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
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
            this.monthlysalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalaryGridView = new Telerik.WinControls.UI.RadGridView();
            this.monthlysalaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlysalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlysalaryBindingSource1)).BeginInit();
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
            // monthlysalaryBindingSource
            // 
            this.monthlysalaryBindingSource.DataSource = typeof(Ucas.Data.Monthlysalary);
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
            this.SalaryGridView.MasterTemplate.AutoGenerateColumns = false;
            this.SalaryGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 78;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Contract.Employee.EmployeejobNumber";
            gridViewTextBoxColumn1.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn1.Name = "EmployeejobNumber";
            gridViewTextBoxColumn1.Width = 134;
            gridViewDecimalColumn2.DataType = typeof(string);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Contract.Employee.EmployeeName";
            gridViewDecimalColumn2.HeaderText = "اسم الموظف";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "EmployeeName";
            gridViewDecimalColumn2.Width = 347;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Amount";
            gridViewDecimalColumn3.HeaderText = "الراتب";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Amount";
            gridViewDecimalColumn3.Width = 152;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "IssueDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ الاصدار";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "IssueDate";
            gridViewDateTimeColumn1.Width = 116;
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "Formonth";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "مستحق لشهر";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Formonth";
            gridViewDateTimeColumn2.Width = 114;
            gridViewDecimalColumn4.DataType = typeof(string);
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
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 80;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Name = "DeleteCol";
            gridViewCommandColumn2.Width = 80;
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
            this.SalaryGridView.MasterTemplate.DataSource = this.monthlysalaryBindingSource1;
            sortDescriptor1.PropertyName = "ID";
            this.SalaryGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.SalaryGridView.Name = "SalaryGridView";
            this.SalaryGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalaryGridView.Size = new System.Drawing.Size(1114, 786);
            this.SalaryGridView.TabIndex = 6;
            this.SalaryGridView.Text = "SalaryGridView";
            this.SalaryGridView.ThemeName = "TelerikMetro";
            // 
            // monthlysalaryBindingSource1
            // 
            this.monthlysalaryBindingSource1.DataSource = typeof(Ucas.Data.Monthlysalary);
            // 
            // FrmSalariesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 825);
            this.Controls.Add(this.SalaryGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmSalariesManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ادارة الرواتب";
            this.ThemeName = "TelerikMetro";
            this.Activated += new System.EventHandler(this.FrmSalariesManage_Activated);
            this.Load += new System.EventHandler(this.FrmSalariesManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlysalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlysalaryBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource monthlysalaryBindingSource;
        private Telerik.WinControls.UI.RadGridView SalaryGridView;
        private System.Windows.Forms.BindingSource monthlysalaryBindingSource1;
    }
}

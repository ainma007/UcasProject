namespace UcasProWindowsForm.Forms.EmployeeForm
{
    partial class FrmEmployeeMng
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeMng));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.EmployeeGridView = new Telerik.WinControls.UI.RadGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeGridView.MasterTemplate.AllowColumnReorder = false;
            this.EmployeeGridView.MasterTemplate.AllowSearchRow = true;
            this.EmployeeGridView.MasterTemplate.AutoGenerateColumns = false;
            this.EmployeeGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 67;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "EmployeejobNumber";
            gridViewTextBoxColumn1.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "EmployeejobNumber";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 172;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "EmployeeName";
            gridViewTextBoxColumn2.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "EmployeeName";
            gridViewTextBoxColumn2.Width = 202;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "EmployeeGender";
            gridViewComboBoxColumn1.HeaderText = "الجنس";
            gridViewComboBoxColumn1.Name = "EmployeeGender";
            gridViewComboBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewComboBoxColumn1.Width = 109;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PhoneNumber";
            gridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PhoneNumber";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 128;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Mobilenumber";
            gridViewTextBoxColumn4.HeaderText = "رقم الجوال";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Mobilenumber";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 128;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 131;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "EmployeeNationalNumber";
            gridViewTextBoxColumn6.HeaderText = "رقم الهوية";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "EmployeeNationalNumber";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 172;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "حفظ";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.MaxWidth = 45;
            gridViewCommandColumn1.MinWidth = 45;
            gridViewCommandColumn1.Name = "EditBtn";
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.MaxWidth = 45;
            gridViewCommandColumn2.MinWidth = 45;
            gridViewCommandColumn2.Name = "deltebtn";
            gridViewCommandColumn2.Width = 45;
            this.EmployeeGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.EmployeeGridView.MasterTemplate.DataSource = this.employeeBindingSource;
            this.EmployeeGridView.MasterTemplate.EnableFiltering = true;
            this.EmployeeGridView.MasterTemplate.EnableGrouping = false;
            this.EmployeeGridView.MasterTemplate.EnableSorting = false;
            this.EmployeeGridView.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            sortDescriptor1.PropertyName = "ID";
            this.EmployeeGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeGridView.Size = new System.Drawing.Size(1144, 766);
            this.EmployeeGridView.TabIndex = 3;
            this.EmployeeGridView.Text = "radGridView1";
            this.EmployeeGridView.ThemeName = "TelerikMetro";
            this.EmployeeGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.EmployeeGridView_CommandCellClick);
            this.EmployeeGridView.Click += new System.EventHandler(this.EmployeeGridView_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Ucas.Data.Employee);
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
            this.toolStrip1.Size = new System.Drawing.Size(1148, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::UcasProWindowsForm.Properties.Resources.Add1;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(106, 36);
            this.AddBtn.Text = "اضافة موظف";
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
            this.toolStripButton2.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.statusStrip1);
            this.radGroupBox1.Controls.Add(this.EmployeeGridView);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "بيانات الموظفين";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 39);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1148, 786);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "بيانات الموظفين";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(2, 762);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1144, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // FrmEmployeeMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 825);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEmployeeMng";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "radRibbonBar1";
            this.ThemeName = "TelerikMetro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmEmployeeMng_Activated);
            this.Load += new System.EventHandler(this.FrmEmployeeMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView EmployeeGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

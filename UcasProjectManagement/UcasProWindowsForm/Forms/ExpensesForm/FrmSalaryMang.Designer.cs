namespace UcasProWindowsForm.Forms.ExpensesForm
{
    partial class FrmSalaryMang
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ReleaseDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.FromonthDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.SalaryTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.ContractComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromonthDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.ReleaseDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel12);
            this.radGroupBox1.Controls.Add(this.FromonthDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel10);
            this.radGroupBox1.Controls.Add(this.SalaryTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel9);
            this.radGroupBox1.Controls.Add(this.ContractComboBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات الراتب";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(360, 229);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات الراتب";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(219, 174);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 44);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.ThemeName = "TelerikMetro";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Location = new System.Drawing.Point(278, 125);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(68, 18);
            this.radLabel4.TabIndex = 20;
            this.radLabel4.Text = "تاريخ الاصدار:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReleaseDateTimePicker
            // 
            this.ReleaseDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ReleaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReleaseDateTimePicker.Location = new System.Drawing.Point(170, 123);
            this.ReleaseDateTimePicker.Name = "ReleaseDateTimePicker";
            this.ReleaseDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReleaseDateTimePicker.Size = new System.Drawing.Size(106, 22);
            this.ReleaseDateTimePicker.TabIndex = 3;
            this.ReleaseDateTimePicker.TabStop = false;
            this.ReleaseDateTimePicker.Text = "15/09/2014";
            this.ReleaseDateTimePicker.ThemeName = "TelerikMetro";
            this.ReleaseDateTimePicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // radLabel12
            // 
            this.radLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel12.Location = new System.Drawing.Point(278, 40);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(70, 18);
            this.radLabel12.TabIndex = 14;
            this.radLabel12.Text = "اسم الموظف:";
            this.radLabel12.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // FromonthDateTimePicker
            // 
            this.FromonthDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromonthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FromonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromonthDateTimePicker.Location = new System.Drawing.Point(170, 93);
            this.FromonthDateTimePicker.Name = "FromonthDateTimePicker";
            this.FromonthDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromonthDateTimePicker.Size = new System.Drawing.Size(106, 22);
            this.FromonthDateTimePicker.TabIndex = 2;
            this.FromonthDateTimePicker.TabStop = false;
            this.FromonthDateTimePicker.Text = "15/09/2014";
            this.FromonthDateTimePicker.ThemeName = "TelerikMetro";
            this.FromonthDateTimePicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // radLabel10
            // 
            this.radLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel10.Location = new System.Drawing.Point(278, 68);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(36, 18);
            this.radLabel10.TabIndex = 18;
            this.radLabel10.Text = "الراتب:";
            this.radLabel10.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTextBox.Location = new System.Drawing.Point(151, 66);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalaryTextBox.Size = new System.Drawing.Size(125, 22);
            this.SalaryTextBox.TabIndex = 1;
            this.SalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SalaryTextBox.ThemeName = "TelerikMetro";
            this.SalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryTextBox_KeyPress);
            // 
            // radLabel9
            // 
            this.radLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel9.Location = new System.Drawing.Point(279, 95);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(73, 18);
            this.radLabel9.TabIndex = 19;
            this.radLabel9.Text = "مستحقة لشهر:";
            this.radLabel9.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ContractComboBox
            // 
            this.ContractComboBox.DisplayMember = "Status";
            // 
            // ContractComboBox.NestedRadGridView
            // 
            this.ContractComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ContractComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContractComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ContractComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ContractComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContractComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // ContractComboBox.NestedRadGridView
            // 
            this.ContractComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ContractComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ContractComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ContractComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ID";
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ID";
            gridViewTextBoxColumn4.Width = 57;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "EmployeeName";
            gridViewTextBoxColumn5.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn5.Name = "EmployeeName";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 122;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "EmployeejobNumber";
            gridViewTextBoxColumn6.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn6.Name = "EmployeejobNumber";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 99;
            this.ContractComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.ContractComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ContractComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ContractComboBox.EditorControl.Name = "NestedRadGridView";
            this.ContractComboBox.EditorControl.ReadOnly = true;
            this.ContractComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContractComboBox.EditorControl.ShowGroupPanel = false;
            this.ContractComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ContractComboBox.EditorControl.TabIndex = 0;
            this.ContractComboBox.Location = new System.Drawing.Point(23, 38);
            this.ContractComboBox.Name = "ContractComboBox";
            this.ContractComboBox.Size = new System.Drawing.Size(253, 20);
            this.ContractComboBox.TabIndex = 0;
            this.ContractComboBox.TabStop = false;
            this.ContractComboBox.ThemeName = "TelerikMetro";
            // 
            // FrmSalaryMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 229);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmSalaryMang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "تعديل بيانات راتب";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FrmSalaryMang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromonthDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        public Telerik.WinControls.UI.RadMultiColumnComboBox ContractComboBox;
        public Telerik.WinControls.UI.RadDateTimePicker ReleaseDateTimePicker;
        public Telerik.WinControls.UI.RadDateTimePicker FromonthDateTimePicker;
        public Telerik.WinControls.UI.RadTextBox SalaryTextBox;
    }
}

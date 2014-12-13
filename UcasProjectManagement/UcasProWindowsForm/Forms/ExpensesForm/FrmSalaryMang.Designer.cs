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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Coinlabel = new System.Windows.Forms.Label();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ReleaseDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.FromonthDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.SalaryTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.EmployeeComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Coinlabel);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.ReleaseDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel12);
            this.radGroupBox1.Controls.Add(this.FromonthDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel10);
            this.radGroupBox1.Controls.Add(this.SalaryTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel9);
            this.radGroupBox1.Controls.Add(this.EmployeeComboBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات الراتب";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(360, 229);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات الراتب";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // Coinlabel
            // 
            this.Coinlabel.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel.Location = new System.Drawing.Point(92, 66);
            this.Coinlabel.Name = "Coinlabel";
            this.Coinlabel.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel.TabIndex = 21;
            this.Coinlabel.Text = "-";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::UcasProWindowsForm.Properties.Resources.SaveChang;
            this.SaveBtn.Location = new System.Drawing.Point(219, 174);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 44);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.radLabel10.Location = new System.Drawing.Point(278, 66);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(36, 18);
            this.radLabel10.TabIndex = 18;
            this.radLabel10.Text = "الراتب:";
            this.radLabel10.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTextBox.Location = new System.Drawing.Point(195, 65);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalaryTextBox.Size = new System.Drawing.Size(81, 22);
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
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.DisplayMember = "Status";
            // 
            // EmployeeComboBox.NestedRadGridView
            // 
            this.EmployeeComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeeComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EmployeeComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 57;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Employee.EmployeeName";
            gridViewTextBoxColumn2.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "Employee.EmployeeName";
            gridViewTextBoxColumn2.Width = 122;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Employee.EmployeejobNumber";
            gridViewTextBoxColumn3.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn3.Name = "Employee.EmployeejobNumber";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 99;
            this.EmployeeComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.EmployeeComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmployeeComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmployeeComboBox.EditorControl.ReadOnly = true;
            this.EmployeeComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeComboBox.EditorControl.ShowGroupPanel = false;
            this.EmployeeComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmployeeComboBox.EditorControl.TabIndex = 0;
            this.EmployeeComboBox.Location = new System.Drawing.Point(23, 38);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(253, 20);
            this.EmployeeComboBox.TabIndex = 0;
            this.EmployeeComboBox.TabStop = false;
            this.EmployeeComboBox.ThemeName = "TelerikMetro";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات راتب";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSalaryMang_FormClosed);
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
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        public Telerik.WinControls.UI.RadMultiColumnComboBox EmployeeComboBox;
        public Telerik.WinControls.UI.RadDateTimePicker ReleaseDateTimePicker;
        public Telerik.WinControls.UI.RadDateTimePicker FromonthDateTimePicker;
        public Telerik.WinControls.UI.RadTextBox SalaryTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Coinlabel;
    }
}

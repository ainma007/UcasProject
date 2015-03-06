namespace UcasProWindowsForm.Forms.EmployeeForm
{
    partial class FrmContractsAdd
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Coinlabel2 = new System.Windows.Forms.Label();
            this.Coinlabel = new System.Windows.Forms.Label();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.EmployeeComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.TotaltextBox = new Telerik.WinControls.UI.RadTextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.SalaryTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.EndDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.StartDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotaltextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Coinlabel2);
            this.radGroupBox1.Controls.Add(this.Coinlabel);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.EmployeeComboBox);
            this.radGroupBox1.Controls.Add(this.TotaltextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.SalaryTextBox);
            this.radGroupBox1.Controls.Add(this.EndDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.StartDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات الاضافة";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(347, 265);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "بيانات الاضافة";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // Coinlabel2
            // 
            this.Coinlabel2.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel2.Location = new System.Drawing.Point(80, 122);
            this.Coinlabel2.Name = "Coinlabel2";
            this.Coinlabel2.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel2.TabIndex = 14;
            this.Coinlabel2.Text = "-";
            // 
            // Coinlabel
            // 
            this.Coinlabel.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel.Location = new System.Drawing.Point(80, 156);
            this.Coinlabel.Name = "Coinlabel";
            this.Coinlabel.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel.TabIndex = 13;
            this.Coinlabel.Text = "-";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(267, 156);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(58, 18);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "قيمة العقد:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeComboBox.DisplayMember = "EmployeeName";
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
            // EmployeeComboBox.NestedRadGridView
            // 
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "EmployeeName";
            gridViewTextBoxColumn1.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "EmployeeName";
            gridViewTextBoxColumn1.Width = 134;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "EmployeejobNumber";
            gridViewTextBoxColumn2.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "EmployeejobNumber";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 87;
            this.EmployeeComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.EmployeeComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmployeeComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmployeeComboBox.EditorControl.ReadOnly = true;
            this.EmployeeComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeComboBox.EditorControl.ShowGroupPanel = false;
            this.EmployeeComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmployeeComboBox.EditorControl.TabIndex = 0;
            this.EmployeeComboBox.Location = new System.Drawing.Point(12, 30);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(252, 20);
            this.EmployeeComboBox.TabIndex = 0;
            this.EmployeeComboBox.TabStop = false;
            this.EmployeeComboBox.Text = "اختر الموظف";
            this.EmployeeComboBox.ThemeName = "TelerikMetro";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotaltextBox.Location = new System.Drawing.Point(183, 152);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotaltextBox.Size = new System.Drawing.Size(81, 22);
            this.TotaltextBox.TabIndex = 3;
            this.TotaltextBox.TabStop = false;
            this.TotaltextBox.Text = "0";
            this.TotaltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotaltextBox.ThemeName = "TelerikMetro";
            this.TotaltextBox.TextChanged += new System.EventHandler(this.TotaltextBox_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Image = global::UcasProWindowsForm.Properties.Resources.addadd;
            this.AddBtn.Location = new System.Drawing.Point(208, 201);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(127, 44);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "اضافة السجل";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "TelerikMetro";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Location = new System.Drawing.Point(267, 121);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(73, 18);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "الراتب الشهري:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTextBox.Location = new System.Drawing.Point(183, 119);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalaryTextBox.Size = new System.Drawing.Size(81, 22);
            this.SalaryTextBox.TabIndex = 4;
            this.SalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SalaryTextBox.ThemeName = "TelerikMetro";
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            this.SalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryTextBox_KeyPress);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(167, 92);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDateTimePicker.Size = new System.Drawing.Size(97, 22);
            this.EndDateTimePicker.TabIndex = 2;
            this.EndDateTimePicker.TabStop = false;
            this.EndDateTimePicker.Text = "15/09/2014";
            this.EndDateTimePicker.ThemeName = "TelerikMetro";
            this.EndDateTimePicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            this.EndDateTimePicker.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Location = new System.Drawing.Point(270, 94);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "تاريخ الانتهاء:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(167, 60);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDateTimePicker.Size = new System.Drawing.Size(97, 22);
            this.StartDateTimePicker.TabIndex = 1;
            this.StartDateTimePicker.TabStop = false;
            this.StartDateTimePicker.Text = "15/09/2014";
            this.StartDateTimePicker.ThemeName = "TelerikMetro";
            this.StartDateTimePicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            this.StartDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Location = new System.Drawing.Point(270, 62);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(55, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "تاريخ البدء:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(270, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(48, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "الموظف:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmContractsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 265);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 300);
            this.Name = "FrmContractsAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(355, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة عقد";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmContractsAdd_FormClosed);
            this.Load += new System.EventHandler(this.FrmContractsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotaltextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmployeeComboBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox SalaryTextBox;
        private Telerik.WinControls.UI.RadDateTimePicker EndDateTimePicker;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker StartDateTimePicker;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TotaltextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Coinlabel2;
        private System.Windows.Forms.Label Coinlabel;
    }
}

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    partial class FrmEditExpense
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.BillTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.RequiarAmountTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.DateOfProecssPicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.CashingNumberTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ExpensesNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.SupplierComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubActivtiesComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.projectSubActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequiarAmountTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfProecssPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashingNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivtiesComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivtiesComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivtiesComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSubActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.BillTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.RequiarAmountTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.DateOfProecssPicker);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.CashingNumberTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.ExpensesNameTextBox);
            this.radGroupBox1.Controls.Add(this.SupplierComboBox);
            this.radGroupBox1.Controls.Add(this.SubActivtiesComboBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات المصروف";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(379, 286);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات المصروف";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(234, 236);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 44);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.ThemeName = "TelerikMetro";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Location = new System.Drawing.Point(294, 205);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(37, 18);
            this.radLabel4.TabIndex = 20;
            this.radLabel4.Text = "المورد:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // BillTextBox
            // 
            this.BillTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BillTextBox.Location = new System.Drawing.Point(155, 116);
            this.BillTextBox.Name = "BillTextBox";
            this.BillTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BillTextBox.Size = new System.Drawing.Size(129, 22);
            this.BillTextBox.TabIndex = 4;
            this.BillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BillTextBox.ThemeName = "TelerikMetro";
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Location = new System.Drawing.Point(289, 36);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(76, 18);
            this.radLabel7.TabIndex = 13;
            this.radLabel7.Text = "النشاط الفرعي:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Location = new System.Drawing.Point(290, 148);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(86, 18);
            this.radLabel6.TabIndex = 21;
            this.radLabel6.Text = "المبلغ المخصص:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // RequiarAmountTextBox
            // 
            this.RequiarAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequiarAmountTextBox.Location = new System.Drawing.Point(155, 147);
            this.RequiarAmountTextBox.Name = "RequiarAmountTextBox";
            this.RequiarAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RequiarAmountTextBox.Size = new System.Drawing.Size(129, 22);
            this.RequiarAmountTextBox.TabIndex = 5;
            this.RequiarAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RequiarAmountTextBox.ThemeName = "TelerikMetro";
            this.RequiarAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequiarAmountTextBox_KeyPress);
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.Location = new System.Drawing.Point(289, 176);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(82, 18);
            this.radLabel5.TabIndex = 19;
            this.radLabel5.Text = "رقم سند الصرف:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateOfProecssPicker
            // 
            this.DateOfProecssPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfProecssPicker.CustomFormat = "dd/MM/yyyy";
            this.DateOfProecssPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfProecssPicker.Location = new System.Drawing.Point(181, 87);
            this.DateOfProecssPicker.Name = "DateOfProecssPicker";
            this.DateOfProecssPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateOfProecssPicker.Size = new System.Drawing.Size(103, 22);
            this.DateOfProecssPicker.TabIndex = 2;
            this.DateOfProecssPicker.TabStop = false;
            this.DateOfProecssPicker.Text = "15/09/2014";
            this.DateOfProecssPicker.ThemeName = "TelerikMetro";
            this.DateOfProecssPicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Location = new System.Drawing.Point(289, 89);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(61, 18);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "تاريخ الشراء:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // CashingNumberTextBox
            // 
            this.CashingNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CashingNumberTextBox.Location = new System.Drawing.Point(155, 174);
            this.CashingNumberTextBox.Name = "CashingNumberTextBox";
            this.CashingNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CashingNumberTextBox.Size = new System.Drawing.Size(129, 22);
            this.CashingNumberTextBox.TabIndex = 6;
            this.CashingNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CashingNumberTextBox.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(289, 117);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(62, 18);
            this.radLabel2.TabIndex = 16;
            this.radLabel2.Text = "رقم الفاتورة:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(290, 62);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(75, 18);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "اسم المصروف:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ExpensesNameTextBox
            // 
            this.ExpensesNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesNameTextBox.Location = new System.Drawing.Point(28, 60);
            this.ExpensesNameTextBox.Name = "ExpensesNameTextBox";
            this.ExpensesNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.ExpensesNameTextBox.TabIndex = 1;
            this.ExpensesNameTextBox.ThemeName = "TelerikMetro";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierComboBox.DataSource = this.supplierBindingSource;
            this.SupplierComboBox.DisplayMember = "Name";
            // 
            // SupplierComboBox.NestedRadGridView
            // 
            this.SupplierComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.SupplierComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.SupplierComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SupplierComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SupplierComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SupplierComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.SupplierComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.SupplierComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.SupplierComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.SupplierComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "اختر المورد";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.Width = 238;
            this.SupplierComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1});
            this.SupplierComboBox.EditorControl.MasterTemplate.DataSource = this.supplierBindingSource;
            this.SupplierComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.SupplierComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.SupplierComboBox.EditorControl.Name = "NestedRadGridView";
            this.SupplierComboBox.EditorControl.ReadOnly = true;
            this.SupplierComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SupplierComboBox.EditorControl.ShowGroupPanel = false;
            this.SupplierComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.SupplierComboBox.EditorControl.TabIndex = 0;
            this.SupplierComboBox.Location = new System.Drawing.Point(28, 205);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(260, 20);
            this.SupplierComboBox.TabIndex = 7;
            this.SupplierComboBox.TabStop = false;
            this.SupplierComboBox.ThemeName = "TelerikMetro";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Ucas.Data.Supplier);
            // 
            // SubActivtiesComboBox
            // 
            this.SubActivtiesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubActivtiesComboBox.DataSource = this.projectSubActivityBindingSource;
            // 
            // SubActivtiesComboBox.NestedRadGridView
            // 
            this.SubActivtiesComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.SubActivtiesComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.SubActivtiesComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SubActivtiesComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubActivtiesComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SubActivtiesComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SubActivityName";
            gridViewTextBoxColumn2.HeaderText = "اختر النشاط";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "SubActivityName";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 187;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2});
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.DataSource = this.projectSubActivityBindingSource;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.SubActivtiesComboBox.EditorControl.Name = "NestedRadGridView";
            this.SubActivtiesComboBox.EditorControl.ReadOnly = true;
            this.SubActivtiesComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubActivtiesComboBox.EditorControl.ShowGroupPanel = false;
            this.SubActivtiesComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.SubActivtiesComboBox.EditorControl.TabIndex = 0;
            this.SubActivtiesComboBox.Location = new System.Drawing.Point(28, 34);
            this.SubActivtiesComboBox.Name = "SubActivtiesComboBox";
            this.SubActivtiesComboBox.Size = new System.Drawing.Size(256, 20);
            this.SubActivtiesComboBox.TabIndex = 0;
            this.SubActivtiesComboBox.TabStop = false;
            this.SubActivtiesComboBox.ThemeName = "TelerikMetro";
            // 
            // projectSubActivityBindingSource
            // 
            this.projectSubActivityBindingSource.DataSource = typeof(Ucas.Data.ProjectSubActivity);
            // 
            // FrmEditExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 286);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 321);
            this.Name = "FrmEditExpense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(387, 321);
            this.Text = "تعديل مصروف";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FrmEditExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequiarAmountTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfProecssPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashingNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivtiesComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivtiesComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivtiesComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSubActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadMultiColumnComboBox SupplierComboBox;
        public Telerik.WinControls.UI.RadMultiColumnComboBox SubActivtiesComboBox;
        public Telerik.WinControls.UI.RadTextBox BillTextBox;
        public Telerik.WinControls.UI.RadTextBox RequiarAmountTextBox;
        public Telerik.WinControls.UI.RadDateTimePicker DateOfProecssPicker;
        public Telerik.WinControls.UI.RadTextBox CashingNumberTextBox;
        public Telerik.WinControls.UI.RadTextBox ExpensesNameTextBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource projectSubActivityBindingSource;
    }
}

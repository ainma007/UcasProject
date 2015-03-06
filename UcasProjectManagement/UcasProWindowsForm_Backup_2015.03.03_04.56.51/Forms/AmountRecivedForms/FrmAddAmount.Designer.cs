namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    partial class FrmAddAmount
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
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Coinlabel = new System.Windows.Forms.Label();
            this.CostTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfProecssPicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DonorsComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfProecssPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Coinlabel);
            this.radGroupBox1.Controls.Add(this.CostTextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.DateOfProecssPicker);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.DonorsComboBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "ادخال بيانات دفعة";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(335, 210);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "ادخال بيانات دفعة";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // Coinlabel
            // 
            this.Coinlabel.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel.Location = new System.Drawing.Point(64, 94);
            this.Coinlabel.Name = "Coinlabel";
            this.Coinlabel.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel.TabIndex = 1;
            this.Coinlabel.Text = "-";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(169, 91);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CostTextBox.Size = new System.Drawing.Size(81, 22);
            this.CostTextBox.TabIndex = 2;
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CostTextBox.ThemeName = "TelerikMetro";
            this.CostTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CostTextBox_KeyDown);
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "مبلغ الدفعة:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاريخ الاستلام:";
            // 
            // DateOfProecssPicker
            // 
            this.DateOfProecssPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfProecssPicker.CustomFormat = "dd/MM/yyyy";
            this.DateOfProecssPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfProecssPicker.Location = new System.Drawing.Point(169, 59);
            this.DateOfProecssPicker.Name = "DateOfProecssPicker";
            this.DateOfProecssPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateOfProecssPicker.Size = new System.Drawing.Size(81, 22);
            this.DateOfProecssPicker.TabIndex = 1;
            this.DateOfProecssPicker.TabStop = false;
            this.DateOfProecssPicker.Text = "06/02/2015";
            this.DateOfProecssPicker.ThemeName = "TelerikMetro";
            this.DateOfProecssPicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الممول:";
            // 
            // DonorsComboBox
            // 
            this.DonorsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // DonorsComboBox.NestedRadGridView
            // 
            this.DonorsComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.DonorsComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.DonorsComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DonorsComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DonorsComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DonorsComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.DonorsComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.DonorsComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.DonorsComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.DonorsComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.Width = 55;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TheDonor.Name";
            gridViewTextBoxColumn2.HeaderText = "اختر الممول";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "TheDonor.Name";
            gridViewTextBoxColumn2.Width = 220;
            this.DonorsComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.DonorsComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.DonorsComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.DonorsComboBox.EditorControl.Name = "NestedRadGridView";
            this.DonorsComboBox.EditorControl.ReadOnly = true;
            this.DonorsComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DonorsComboBox.EditorControl.ShowGroupPanel = false;
            this.DonorsComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.DonorsComboBox.EditorControl.TabIndex = 0;
            this.DonorsComboBox.Location = new System.Drawing.Point(27, 31);
            this.DonorsComboBox.Name = "DonorsComboBox";
            this.DonorsComboBox.Size = new System.Drawing.Size(223, 20);
            this.DonorsComboBox.TabIndex = 0;
            this.DonorsComboBox.TabStop = false;
            this.DonorsComboBox.ThemeName = "TelerikMetro";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::UcasProWindowsForm.Properties.Resources.addadd;
            this.AddBtn.Location = new System.Drawing.Point(196, 149);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(127, 44);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "اضافة سجل";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "TelerikMetro";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FrmAddAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 210);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(343, 240);
            this.Name = "FrmAddAmount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(343, 240);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة دفعة";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddAmount_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfProecssPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox DonorsComboBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDateTimePicker DateOfProecssPicker;
        private Telerik.WinControls.UI.RadTextBox CostTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Coinlabel;
    }
}

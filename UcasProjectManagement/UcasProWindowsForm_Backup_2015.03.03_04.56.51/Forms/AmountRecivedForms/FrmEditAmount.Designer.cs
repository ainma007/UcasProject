namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    partial class FrmEditAmount
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
            this.GroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.Coinlabel = new System.Windows.Forms.Label();
            this.DonorsComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfProecssPicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.CostTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfProecssPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GroupBox.Controls.Add(this.Coinlabel);
            this.GroupBox.Controls.Add(this.saveBtn);
            this.GroupBox.Controls.Add(this.DonorsComboBox);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.DateOfProecssPicker);
            this.GroupBox.Controls.Add(this.CostTextBox);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.HeaderText = "بيانات الدفعة";
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(324, 187);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.Text = "بيانات الدفعة";
            this.GroupBox.ThemeName = "TelerikMetro";
            // 
            // Coinlabel
            // 
            this.Coinlabel.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel.Location = new System.Drawing.Point(49, 80);
            this.Coinlabel.Name = "Coinlabel";
            this.Coinlabel.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel.TabIndex = 2;
            this.Coinlabel.Text = "-";
            // 
            // DonorsComboBox
            // 
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
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 100;
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
            this.DonorsComboBox.Location = new System.Drawing.Point(12, 21);
            this.DonorsComboBox.Name = "DonorsComboBox";
            this.DonorsComboBox.Size = new System.Drawing.Size(223, 20);
            this.DonorsComboBox.TabIndex = 11;
            this.DonorsComboBox.TabStop = false;
            this.DonorsComboBox.ThemeName = "TelerikMetro";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "مبلغ الدفعة:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "تاريخ الاستلام:";
            // 
            // DateOfProecssPicker
            // 
            this.DateOfProecssPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfProecssPicker.CustomFormat = "dd/MM/yyyy";
            this.DateOfProecssPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfProecssPicker.Location = new System.Drawing.Point(154, 48);
            this.DateOfProecssPicker.Name = "DateOfProecssPicker";
            this.DateOfProecssPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateOfProecssPicker.Size = new System.Drawing.Size(81, 22);
            this.DateOfProecssPicker.TabIndex = 8;
            this.DateOfProecssPicker.TabStop = false;
            this.DateOfProecssPicker.Text = "06/02/2015";
            this.DateOfProecssPicker.ThemeName = "TelerikMetro";
            this.DateOfProecssPicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(154, 77);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CostTextBox.Size = new System.Drawing.Size(81, 22);
            this.CostTextBox.TabIndex = 7;
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CostTextBox.ThemeName = "TelerikMetro";
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "الممول:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::UcasProWindowsForm.Properties.Resources.SaveChang;
            this.saveBtn.Location = new System.Drawing.Point(184, 126);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(127, 44);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "حفظ التعديلات";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.ThemeName = "TelerikMetro";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // FrmEditAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 187);
            this.Controls.Add(this.GroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 217);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 217);
            this.Name = "FrmEditAmount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(332, 217);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات دفعة";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEditAmount_FormClosed);
            this.Load += new System.EventHandler(this.FrmEditAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfProecssPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Telerik.WinControls.UI.RadGroupBox GroupBox;
        public Telerik.WinControls.UI.RadMultiColumnComboBox DonorsComboBox;
        public Telerik.WinControls.UI.RadDateTimePicker DateOfProecssPicker;
        public Telerik.WinControls.UI.RadTextBox CostTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Coinlabel;
    }
}

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    partial class FrmTheDonorsAndProjectEdit
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CostTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.DonorsColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Coinlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Coinlabel);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.CostTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.DonorsColumnComboBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات التعديل";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(374, 170);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات التعديل";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Image = global::UcasProWindowsForm.Properties.Resources.SaveChang;
            this.SaveBtn.Location = new System.Drawing.Point(235, 121);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 44);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "TelerikMetro";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(290, 73);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 16);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "مبلغ المنحة:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "TelerikMetro";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(205, 70);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CostTextBox.Size = new System.Drawing.Size(81, 22);
            this.CostTextBox.TabIndex = 6;
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CostTextBox.ThemeName = "TelerikMetro";
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(290, 41);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(65, 16);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "اسم الممول:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "TelerikMetro";
            // 
            // DonorsColumnComboBox
            // 
            this.DonorsColumnComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // DonorsColumnComboBox.NestedRadGridView
            // 
            this.DonorsColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.DonorsColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.DonorsColumnComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DonorsColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DonorsColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DonorsColumnComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // DonorsColumnComboBox.NestedRadGridView
            // 
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ID";
            gridViewTextBoxColumn3.HeaderText = "column1";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ID";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Name";
            gridViewTextBoxColumn4.HeaderText = "اختر الممول";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "Name";
            gridViewTextBoxColumn4.Width = 220;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor2.PropertyName = "column1";
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.DonorsColumnComboBox.EditorControl.Name = "NestedRadGridView";
            this.DonorsColumnComboBox.EditorControl.ReadOnly = true;
            this.DonorsColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DonorsColumnComboBox.EditorControl.ShowGroupPanel = false;
            this.DonorsColumnComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.DonorsColumnComboBox.EditorControl.TabIndex = 0;
            this.DonorsColumnComboBox.Location = new System.Drawing.Point(9, 34);
            this.DonorsColumnComboBox.Name = "DonorsColumnComboBox";
            this.DonorsColumnComboBox.Size = new System.Drawing.Size(279, 20);
            this.DonorsColumnComboBox.TabIndex = 0;
            this.DonorsColumnComboBox.TabStop = false;
            this.DonorsColumnComboBox.ThemeName = "TelerikMetro";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Coinlabel
            // 
            this.Coinlabel.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel.Location = new System.Drawing.Point(102, 72);
            this.Coinlabel.Name = "Coinlabel";
            this.Coinlabel.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel.TabIndex = 17;
            this.Coinlabel.Text = "-";
            // 
            // FrmTheDonorsAndProjectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 170);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 205);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 205);
            this.Name = "FrmTheDonorsAndProjectEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(382, 205);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات ممول مشروع";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FrmTheDonorsAndProjectEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsColumnComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadMultiColumnComboBox DonorsColumnComboBox;
        public Telerik.WinControls.UI.RadTextBox CostTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Coinlabel;
    }
}

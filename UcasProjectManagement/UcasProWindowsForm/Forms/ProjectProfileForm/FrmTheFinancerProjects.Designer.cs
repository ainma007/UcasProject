namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    partial class FrmTheFinancerProjects
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
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ThefinanciersComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.CostTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThefinanciersComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThefinanciersComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThefinanciersComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.ThefinanciersComboBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.CostTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "اضافة ممول للمشروع";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(410, 201);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "اضافة ممول للمشروع";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(266, 38);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(132, 19);
            this.radLabel2.TabIndex = 9;
            this.radLabel2.Text = "الممول الخاص بالمشروع:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "Office2013Light";
            // 
            // ThefinanciersComboBox
            // 
            // 
            // ThefinanciersComboBox.NestedRadGridView
            // 
            this.ThefinanciersComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ThefinanciersComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ThefinanciersComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThefinanciersComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ThefinanciersComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ThefinanciersComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ThefinanciersComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ThefinanciersComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ThefinanciersComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ThefinanciersComboBox.EditorControl.Name = "NestedRadGridView";
            this.ThefinanciersComboBox.EditorControl.ReadOnly = true;
            this.ThefinanciersComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ThefinanciersComboBox.EditorControl.ShowGroupPanel = false;
            this.ThefinanciersComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ThefinanciersComboBox.EditorControl.TabIndex = 0;
            this.ThefinanciersComboBox.Location = new System.Drawing.Point(39, 38);
            this.ThefinanciersComboBox.Name = "ThefinanciersComboBox";
            this.ThefinanciersComboBox.Size = new System.Drawing.Size(221, 20);
            this.ThefinanciersComboBox.TabIndex = 8;
            this.ThefinanciersComboBox.TabStop = false;
            this.ThefinanciersComboBox.Text = "اختر الممول";
            this.ThefinanciersComboBox.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(266, 133);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 38);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(266, 80);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(93, 19);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "المبلغ المخصص:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Office2013Light";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(39, 80);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(221, 21);
            this.CostTextBox.TabIndex = 0;
            this.CostTextBox.ThemeName = "Office2013Light";
            // 
            // FrmTheFinancerProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmTheFinancerProjects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmTheFinancerProjects";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThefinanciersComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThefinanciersComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThefinanciersComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ThefinanciersComboBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox CostTextBox;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}

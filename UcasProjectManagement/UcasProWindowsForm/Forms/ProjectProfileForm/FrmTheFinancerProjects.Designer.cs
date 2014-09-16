﻿namespace UcasProWindowsForm.Forms.ProjectProfileForm
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
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.CostTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radMultiColumnComboBox1);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.CostTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "اضافة ممول للمشروع";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(410, 201);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "اضافة ممول للمشروع";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(266, 133);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 38);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
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
            // radMultiColumnComboBox1
            // 
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(39, 38);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(221, 20);
            this.radMultiColumnComboBox1.TabIndex = 8;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.Text = "اختر الممول";
            this.radMultiColumnComboBox1.ThemeName = "Office2013Light";
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
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox CostTextBox;
    }
}

﻿namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class FrmEditUserToProject
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.UserListComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.userTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.StatusDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ProjectCombo = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserListComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCombo.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCombo.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.UserListComboBox);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.StatusDropDownList);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.ProjectCombo);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات التعديل";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(353, 204);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات التعديل";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // UserListComboBox
            // 
            this.UserListComboBox.DataSource = this.userTbBindingSource;
            this.UserListComboBox.DisplayMember = "ID";
            // 
            // UserListComboBox.NestedRadGridView
            // 
            this.UserListComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.UserListComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserListComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.UserListComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserListComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserListComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.UserListComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.UserListComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.UserListComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.UserListComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.UserListComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.UserListComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(int);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Employee.EmployeeName";
            gridViewTextBoxColumn2.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn2.Name = "Employee.EmployeeName";
            gridViewTextBoxColumn2.Width = 136;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Employee.EmployeejobNumber";
            gridViewTextBoxColumn3.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn3.Name = "Employee.EmployeejobNumber";
            gridViewTextBoxColumn3.Width = 85;
            this.UserListComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.UserListComboBox.EditorControl.MasterTemplate.DataSource = this.userTbBindingSource;
            this.UserListComboBox.EditorControl.MasterTemplate.EnableFiltering = true;
            this.UserListComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.UserListComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.UserListComboBox.EditorControl.Name = "NestedRadGridView";
            this.UserListComboBox.EditorControl.ReadOnly = true;
            this.UserListComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserListComboBox.EditorControl.ShowGroupPanel = false;
            this.UserListComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.UserListComboBox.EditorControl.TabIndex = 0;
            this.UserListComboBox.Location = new System.Drawing.Point(37, 37);
            this.UserListComboBox.Name = "UserListComboBox";
            this.UserListComboBox.Size = new System.Drawing.Size(240, 20);
            this.UserListComboBox.TabIndex = 0;
            this.UserListComboBox.TabStop = false;
            this.UserListComboBox.ThemeName = "TelerikMetro";
            // 
            // userTbBindingSource
            // 
            this.userTbBindingSource.DataSource = typeof(Ucas.Data.UserTb);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::UcasProWindowsForm.Properties.Resources.SaveChang;
            this.SaveBtn.Location = new System.Drawing.Point(198, 144);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(143, 41);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "TelerikMetro";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(275, 99);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(34, 18);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "الحالة:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // StatusDropDownList
            // 
            this.StatusDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "فعال";
            radListDataItem2.Text = "غير فعال";
            this.StatusDropDownList.Items.Add(radListDataItem1);
            this.StatusDropDownList.Items.Add(radListDataItem2);
            this.StatusDropDownList.Location = new System.Drawing.Point(198, 98);
            this.StatusDropDownList.Name = "StatusDropDownList";
            this.StatusDropDownList.Size = new System.Drawing.Size(79, 19);
            this.StatusDropDownList.TabIndex = 9;
            this.StatusDropDownList.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(277, 68);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(46, 18);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "المشروع:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(276, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 18);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "اسم الموظف:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProjectCombo
            // 
            // 
            // ProjectCombo.NestedRadGridView
            // 
            this.ProjectCombo.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectCombo.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProjectCombo.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ProjectCombo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProjectCombo.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProjectCombo.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ProjectCombo.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ProjectCombo.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ProjectCombo.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ProjectCombo.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.ProjectCombo.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ID";
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ID";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ProjectName";
            gridViewTextBoxColumn5.HeaderText = "اسم المشروع";
            gridViewTextBoxColumn5.Name = "ProjectName";
            gridViewTextBoxColumn5.Width = 220;
            this.ProjectCombo.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.ProjectCombo.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ProjectCombo.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ProjectCombo.EditorControl.Name = "NestedRadGridView";
            this.ProjectCombo.EditorControl.ReadOnly = true;
            this.ProjectCombo.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectCombo.EditorControl.ShowGroupPanel = false;
            this.ProjectCombo.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ProjectCombo.EditorControl.TabIndex = 0;
            this.ProjectCombo.Location = new System.Drawing.Point(37, 67);
            this.ProjectCombo.Name = "ProjectCombo";
            this.ProjectCombo.Size = new System.Drawing.Size(240, 20);
            this.ProjectCombo.TabIndex = 1;
            this.ProjectCombo.TabStop = false;
            this.ProjectCombo.ThemeName = "TelerikMetro";
            // 
            // FrmEditUserToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 204);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmEditUserToProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات مستخدم المشروع";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FrmEditUserToProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserListComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCombo.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCombo.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ProjectCombo;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList StatusDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox UserListComboBox;
        private System.Windows.Forms.BindingSource userTbBindingSource;
    }
}

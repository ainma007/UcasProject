namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class FrmUserManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManagment));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn4 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn5 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn1 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn2 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn3 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.projectUserGridView = new Telerik.WinControls.UI.RadGridView();
            this.EmployeebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUserGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(1171, 147);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "radRibbonBar1";
            this.radRibbonBar1.ThemeName = "TelerikMetroBlue";
            this.radRibbonBar1.Click += new System.EventHandler(this.radRibbonBar1_Click);
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 828);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1171, 27);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2013Light";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGridView1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "قائمة المستخدمين العاديين";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 147);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1171, 200);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "قائمة المستخدمين العاديين";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.White;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(2, 18);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ID";
            gridViewTextBoxColumn3.HeaderText = "column1";
            gridViewTextBoxColumn3.Name = "ID";
            gridViewTextBoxColumn3.Width = 182;
            gridViewMultiComboBoxColumn4.EnableExpressionEditor = false;
            gridViewMultiComboBoxColumn4.FieldName = "Employee.ID";
            gridViewMultiComboBoxColumn4.HeaderText = "column1";
            gridViewMultiComboBoxColumn4.Name = "Emloyee";
            gridViewMultiComboBoxColumn4.Width = 231;
            gridViewMultiComboBoxColumn5.EnableExpressionEditor = false;
            gridViewMultiComboBoxColumn5.FieldName = "ProjectControl.ProjectID";
            gridViewMultiComboBoxColumn5.HeaderText = "column1";
            gridViewMultiComboBoxColumn5.Name = "PRoID";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewMultiComboBoxColumn4,
            gridViewMultiComboBoxColumn5});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(1167, 180);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.projectUserGridView);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox2.HeaderText = "قائمة المستخدمين حسب المشاريع";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 347);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(1171, 200);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "قائمة المستخدمين حسب المشاريع";
            this.radGroupBox2.ThemeName = "TelerikMetroBlue";
            // 
            // projectUserGridView
            // 
            this.projectUserGridView.BackColor = System.Drawing.Color.White;
            this.projectUserGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectUserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectUserGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.projectUserGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectUserGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.projectUserGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // projectUserGridView
            // 
            this.projectUserGridView.MasterTemplate.AutoGenerateColumns = false;
            this.projectUserGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "الرقم";
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 144;
            gridViewMultiComboBoxColumn1.EnableExpressionEditor = false;
            gridViewMultiComboBoxColumn1.HeaderText = "الموظف";
            gridViewMultiComboBoxColumn1.Name = "EmployeeID";
            gridViewMultiComboBoxColumn1.Width = 144;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "UserName";
            gridViewTextBoxColumn1.HeaderText = "اسم المستخدم";
            gridViewTextBoxColumn1.Name = "UserName";
            gridViewTextBoxColumn1.Width = 144;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Password";
            gridViewTextBoxColumn2.HeaderText = "كلمة المرور";
            gridViewTextBoxColumn2.Name = "Password";
            gridViewTextBoxColumn2.Width = 144;
            gridViewMultiComboBoxColumn2.EnableExpressionEditor = false;
            gridViewMultiComboBoxColumn2.FieldName = "GroupID";
            gridViewMultiComboBoxColumn2.HeaderText = "المجموعة";
            gridViewMultiComboBoxColumn2.Name = "GroupID";
            gridViewMultiComboBoxColumn2.Width = 144;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "UserID";
            gridViewDecimalColumn2.HeaderText = "UserID";
            gridViewDecimalColumn2.Name = "UserID";
            gridViewDecimalColumn2.Width = 144;
            gridViewMultiComboBoxColumn3.EnableExpressionEditor = false;
            gridViewMultiComboBoxColumn3.FieldName = "ProjectID";
            gridViewMultiComboBoxColumn3.HeaderText = "ProjectID";
            gridViewMultiComboBoxColumn3.Name = "ProjectID";
            gridViewMultiComboBoxColumn3.Width = 144;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "Status";
            gridViewComboBoxColumn1.HeaderText = "Status";
            gridViewComboBoxColumn1.Name = "Status";
            gridViewComboBoxColumn1.Width = 146;
            this.projectUserGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewMultiComboBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewMultiComboBoxColumn2,
            gridViewDecimalColumn2,
            gridViewMultiComboBoxColumn3,
            gridViewComboBoxColumn1});
            this.projectUserGridView.Name = "projectUserGridView";
            this.projectUserGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectUserGridView.Size = new System.Drawing.Size(1167, 180);
            this.projectUserGridView.TabIndex = 0;
            this.projectUserGridView.Text = "radGridView2";
            this.projectUserGridView.ThemeName = "TelerikMetroBlue";
            // 
            // EmployeebindingSource
            // 
            this.EmployeebindingSource.DataSource = typeof(Ucas.Data.Employee);
            // 
            // usersTbBindingSource
            // 
            this.usersTbBindingSource.DataSource = typeof(Ucas.Data.UsersTb);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Ucas.Data.ProjectProfile);
            // 
            // FrmUserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 855);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmUserManagment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radRibbonBar1";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.FrmUserManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectUserGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView projectUserGridView;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.BindingSource EmployeebindingSource;
        private System.Windows.Forms.BindingSource usersTbBindingSource;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

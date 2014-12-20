namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class frmUserManage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManage));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.UserGridView = new Telerik.WinControls.UI.RadGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView.MasterTemplate)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGridView
            // 
            this.UserGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.UserGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UserGridView.ForeColor = System.Drawing.Color.Black;
            this.UserGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // UserGridView
            // 
            this.UserGridView.MasterTemplate.AllowAddNewRow = false;
            this.UserGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 51;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Employee.EmployeeName";
            gridViewTextBoxColumn2.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn2.Name = "EmployeeName";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "UserName";
            gridViewTextBoxColumn3.HeaderText = "اسم المستخدم";
            gridViewTextBoxColumn3.Name = "UserName";
            gridViewTextBoxColumn3.Width = 194;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Password";
            gridViewTextBoxColumn4.HeaderText = "كلمة المرور";
            gridViewTextBoxColumn4.Name = "Password";
            gridViewTextBoxColumn4.Width = 227;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "TypeUser";
            gridViewComboBoxColumn1.HeaderText = "نوع المستخدم";
            gridViewComboBoxColumn1.Name = "TypeUser";
            gridViewComboBoxColumn1.Width = 144;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "تعديل ";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 45;
            gridViewCommandColumn1.MinWidth = 45;
            gridViewCommandColumn1.Name = "Savebtn";
            gridViewCommandColumn1.Width = 45;
            this.UserGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn1,
            gridViewCommandColumn1});
            sortDescriptor1.PropertyName = "ID";
            this.UserGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserGridView.Size = new System.Drawing.Size(776, 440);
            this.UserGridView.TabIndex = 1;
            this.UserGridView.Text = "radGridView2";
            this.UserGridView.ThemeName = "TelerikMetro";
            this.UserGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.UserGridView_CommandCellClick);
            this.UserGridView.Click += new System.EventHandler(this.UserGridView_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.StatusLabel1.Text = "-";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.UserGridView);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "سجل المستخدمين";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(780, 460);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "سجل المستخدمين";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // frmUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 482);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 517);
            this.MinimumSize = new System.Drawing.Size(788, 517);
            this.Name = "frmUserManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(788, 517);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المستخدمين";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserManage_FormClosed);
            this.Load += new System.EventHandler(this.frmUserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView UserGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;


    }
}

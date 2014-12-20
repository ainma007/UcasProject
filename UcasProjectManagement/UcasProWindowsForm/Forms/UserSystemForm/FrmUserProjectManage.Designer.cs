namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class FrmUserProjectManage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserProjectManage));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ProjectControlGridView = new Telerik.WinControls.UI.RadGridView();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectControlGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectControlGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 39);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::UcasProWindowsForm.Properties.Resources.Add1;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(104, 36);
            this.AddBtn.Text = "اضافة مشروع";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::UcasProWindowsForm.Properties.Resources.Refrech;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(117, 36);
            this.RefreshBtn.Text = "تحديث السجلات";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // ProjectControlGridView
            // 
            this.ProjectControlGridView.BackColor = System.Drawing.Color.White;
            this.ProjectControlGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProjectControlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectControlGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectControlGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProjectControlGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProjectControlGridView.Location = new System.Drawing.Point(0, 39);
            // 
            // ProjectControlGridView
            // 
            this.ProjectControlGridView.MasterTemplate.AllowAddNewRow = false;
            this.ProjectControlGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ID";
            gridViewTextBoxColumn5.HeaderText = "ID";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ID";
            gridViewTextBoxColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn5.Width = 47;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "UserTb.Employee.EmployeeName";
            gridViewTextBoxColumn6.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn6.Name = "EmployeeName";
            gridViewTextBoxColumn6.Width = 268;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ProjectProfile.ProjectName";
            gridViewTextBoxColumn7.HeaderText = "اسم المشروع";
            gridViewTextBoxColumn7.Name = "ProjectName";
            gridViewTextBoxColumn7.Width = 238;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Status";
            gridViewTextBoxColumn8.HeaderText = "الحالة";
            gridViewTextBoxColumn8.Name = "Status";
            gridViewTextBoxColumn8.Width = 112;
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderText = "تعديل";
            gridViewCommandColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn3.Image")));
            gridViewCommandColumn3.Name = "EditCol";
            gridViewCommandColumn3.Width = 57;
            gridViewCommandColumn4.EnableExpressionEditor = false;
            gridViewCommandColumn4.HeaderText = "حذف";
            gridViewCommandColumn4.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn4.Image")));
            gridViewCommandColumn4.Name = "DeleteCol";
            gridViewCommandColumn4.Width = 61;
            this.ProjectControlGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCommandColumn3,
            gridViewCommandColumn4});
            sortDescriptor2.PropertyName = "ID";
            this.ProjectControlGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.ProjectControlGridView.Name = "ProjectControlGridView";
            this.ProjectControlGridView.ReadOnly = true;
            this.ProjectControlGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectControlGridView.Size = new System.Drawing.Size(752, 343);
            this.ProjectControlGridView.TabIndex = 8;
            this.ProjectControlGridView.Text = "radGridView1";
            this.ProjectControlGridView.ThemeName = "TelerikMetro";
            this.ProjectControlGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.ProjectControlGridView_CommandCellClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // FrmUserProjectManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 404);
            this.Controls.Add(this.ProjectControlGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 439);
            this.MinimumSize = new System.Drawing.Size(760, 439);
            this.Name = "FrmUserProjectManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة مستخدمين المشاريع";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUserProjectManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmUserProjectManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectControlGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectControlGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Telerik.WinControls.UI.RadGridView ProjectControlGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

namespace UcasProWindowsForm.Forms.supplierForm
{
    partial class FrmManagementFinanciers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagementFinanciers));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.AddBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.SaveBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.RefreshBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.ReportBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.thefinancierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(976, 150);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 1;
            this.radRibbonBar1.Text = "FrmManagementFinanciers";
            this.radRibbonBar1.ThemeName = "Office2013Light";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "العمليات";
            this.ribbonTab1.AccessibleName = "العمليات";
            this.ribbonTab1.AutoEllipsis = false;
            this.ribbonTab1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "العمليات";
            this.ribbonTab1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "العمليات";
            this.radRibbonBarGroup1.AccessibleName = "العمليات";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.AddBtn,
            this.SaveBtn,
            this.RefreshBtn,
            this.ReportBtn});
            this.radRibbonBarGroup1.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup1.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup1.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "العمليات";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // AddBtn
            // 
            this.AddBtn.AccessibleDescription = "اضافة سجل";
            this.AddBtn.AccessibleName = "اضافة سجل";
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Text = "اضافة سجل";
            this.AddBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // SaveBtn
            // 
            this.SaveBtn.AccessibleDescription = "حفظ التغيرات";
            this.SaveBtn.AccessibleName = "حفظ التغيرات";
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Text = "حفظ التغيرات";
            this.SaveBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AccessibleDescription = "تحديث السجلات";
            this.RefreshBtn.AccessibleName = "تحديث السجلات";
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Text = "تحديث السجلات";
            this.RefreshBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // ReportBtn
            // 
            this.ReportBtn.AccessibleDescription = "طباعة تقرير ";
            this.ReportBtn.AccessibleName = "طباعة تقرير ";
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Text = "طباعة تقرير ";
            this.ReportBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 582);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(976, 27);
            this.radStatusStrip1.TabIndex = 2;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2013Light";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 150);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "الرقم";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 94;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "اسم الممول";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 145;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "agentName";
            gridViewTextBoxColumn2.HeaderText = "اسم الوكيل";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "agentName";
            gridViewTextBoxColumn2.Width = 145;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PhoneNumber";
            gridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PhoneNumber";
            gridViewTextBoxColumn3.Width = 145;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Fax";
            gridViewTextBoxColumn4.HeaderText = "الفاكس";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Fax";
            gridViewTextBoxColumn4.Width = 145;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 145;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Adderss";
            gridViewTextBoxColumn6.HeaderText = "العنوان";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Adderss";
            gridViewTextBoxColumn6.Width = 138;
            gridViewTextBoxColumn7.DataType = typeof(System.Collections.Generic.ICollection<Ucas.Data.TheFinancerProject>);
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "TheFinancerProjects";
            gridViewTextBoxColumn7.HeaderText = "TheFinancerProjects";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "TheFinancerProjects";
            gridViewTextBoxColumn7.Width = 77;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView1.MasterTemplate.DataSource = this.thefinancierBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(976, 432);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Office2013Light";
            // 
            // thefinancierBindingSource
            // 
            this.thefinancierBindingSource.DataSource = typeof(Ucas.Data.Thefinancier);
            // 
            // FrmManagementFinanciers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 609);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmManagementFinanciers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmManagementFinanciers";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement AddBtn;
        private Telerik.WinControls.UI.RadButtonElement SaveBtn;
        private Telerik.WinControls.UI.RadButtonElement RefreshBtn;
        private Telerik.WinControls.UI.RadButtonElement ReportBtn;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource thefinancierBindingSource;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
    }
}

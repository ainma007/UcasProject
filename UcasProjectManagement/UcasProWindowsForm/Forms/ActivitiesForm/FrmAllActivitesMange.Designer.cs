namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    partial class FrmAllActivitesMange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAllActivitesMange));
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.AdActivitesBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.AddSupActivitesBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.SaveBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.DeleteBtn = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.ViewReport = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement6 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(1011, 150);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "radRibbonBar1";
            this.radRibbonBar1.ThemeName = "Office2013Light";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "العمليات";
            this.ribbonTab1.AccessibleName = "العمليات";
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "العمليات";
            this.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "اضافة";
            this.radRibbonBarGroup1.AccessibleName = "اضافة";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.AdActivitesBtn,
            this.AddSupActivitesBtn});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "اضافة";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // AdActivitesBtn
            // 
            this.AdActivitesBtn.AccessibleDescription = "اضافة نشاط رئيسي";
            this.AdActivitesBtn.AccessibleName = "اضافة نشاط رئيسي";
            this.AdActivitesBtn.Name = "AdActivitesBtn";
            this.AdActivitesBtn.Text = "اضافة نشاط رئيسي";
            this.AdActivitesBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // AddSupActivitesBtn
            // 
            this.AddSupActivitesBtn.AccessibleDescription = "اضافة نشاط فرعي ";
            this.AddSupActivitesBtn.AccessibleName = "اضافة نشاط فرعي ";
            this.AddSupActivitesBtn.Name = "AddSupActivitesBtn";
            this.AddSupActivitesBtn.Text = "اضافة نشاط فرعي ";
            this.AddSupActivitesBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AccessibleDescription = "تحرير";
            this.radRibbonBarGroup2.AccessibleName = "تحرير";
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.SaveBtn,
            this.DeleteBtn});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "تحرير";
            this.radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // SaveBtn
            // 
            this.SaveBtn.AccessibleDescription = "حفظ التعديلات";
            this.SaveBtn.AccessibleName = "حفظ التعديلات";
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AccessibleDescription = "حذف سجل ";
            this.DeleteBtn.AccessibleName = "حذف سجل ";
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Text = "حذف سجل ";
            this.DeleteBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "التقارير";
            this.radRibbonBarGroup3.AccessibleName = "التقارير";
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ViewReport,
            this.radButtonElement6});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "التقارير";
            this.radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // ViewReport
            // 
            this.ViewReport.AccessibleDescription = "عرض تقرير ";
            this.ViewReport.AccessibleName = "عرض تقرير ";
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Text = "عرض تقرير ";
            this.ViewReport.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement6
            // 
            this.radButtonElement6.AccessibleDescription = "طباعة تقرير";
            this.radButtonElement6.AccessibleName = "طباعة تقرير";
            this.radButtonElement6.Name = "radButtonElement6";
            this.radButtonElement6.Text = "طباعة تقرير";
            this.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AccessibleDescription = "أدوات";
            this.ribbonTab2.AccessibleName = "أدوات";
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "أدوات";
            this.ribbonTab2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 645);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1011, 27);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2013Light";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 150);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1011, 495);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            // 
            // FrmAllActivitesMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 672);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmAllActivitesMange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radRibbonBar1";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement AdActivitesBtn;
        private Telerik.WinControls.UI.RadButtonElement AddSupActivitesBtn;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement SaveBtn;
        private Telerik.WinControls.UI.RadButtonElement DeleteBtn;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement ViewReport;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement6;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}

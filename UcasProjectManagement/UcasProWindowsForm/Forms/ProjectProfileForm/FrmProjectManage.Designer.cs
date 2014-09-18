namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    partial class FrmProjectManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectManage));
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.office2013LightTheme2 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(839, 150);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "s";
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
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "العمليات";
            this.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "العمليات";
            this.radRibbonBarGroup1.AccessibleName = "العمليات";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3,
            this.radButtonElement4});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "العمليات";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "اضافة مشروع";
            this.radButtonElement1.AccessibleName = "اضافة مشروع";
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "اضافة مشروع";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "حفظ التغيرات";
            this.radButtonElement2.AccessibleName = "حفظ التغيرات";
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "حفظ التغيرات";
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "تحديث البيانات";
            this.radButtonElement3.AccessibleName = "تحديث البيانات";
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "تحديث البيانات";
            this.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.AccessibleDescription = "طباعة تقرير ";
            this.radButtonElement4.AccessibleName = "طباعة تقرير ";
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "طباعة تقرير ";
            this.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 590);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(839, 27);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2013Light";
            // 
            // FrmProjectManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 617);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmProjectManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "s";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmProjectManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme2;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
    }
}

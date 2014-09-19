namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class FrmGroupManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupManage));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.PermssionList = new System.Windows.Forms.CheckedListBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.DescreptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.GroupNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.GroupGridView = new Telerik.WinControls.UI.RadGridView();
            this.groupsTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.EditBtn = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescreptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(907, 150);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "radRibbonBar1";
            this.radRibbonBar1.ThemeName = "Office2013Light";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.PermssionList);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.DescreptionTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.GroupNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 150);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(907, 197);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // PermssionList
            // 
            this.PermssionList.FormattingEnabled = true;
            this.PermssionList.Location = new System.Drawing.Point(38, 34);
            this.PermssionList.Name = "PermssionList";
            this.PermssionList.Size = new System.Drawing.Size(418, 140);
            this.PermssionList.TabIndex = 24;
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Location = new System.Drawing.Point(800, 87);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(92, 19);
            this.radLabel7.TabIndex = 23;
            this.radLabel7.Text = "وصف المجموعة:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel7.ThemeName = "Office2013Light";
            // 
            // DescreptionTextBox
            // 
            this.DescreptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescreptionTextBox.AutoSize = false;
            this.DescreptionTextBox.Location = new System.Drawing.Point(601, 87);
            this.DescreptionTextBox.Multiline = true;
            this.DescreptionTextBox.Name = "DescreptionTextBox";
            this.DescreptionTextBox.Size = new System.Drawing.Size(193, 50);
            this.DescreptionTextBox.TabIndex = 22;
            this.DescreptionTextBox.ThemeName = "Office2013Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(800, 48);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 19);
            this.radLabel1.TabIndex = 21;
            this.radLabel1.Text = "اسم المجموعة:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Office2013Light";
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNameTextBox.Location = new System.Drawing.Point(601, 48);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(193, 21);
            this.GroupNameTextBox.TabIndex = 20;
            this.GroupNameTextBox.ThemeName = "Office2013Light";
            // 
            // GroupGridView
            // 
            this.GroupGridView.BackColor = System.Drawing.SystemColors.Control;
            this.GroupGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GroupGridView.Location = new System.Drawing.Point(0, 347);
            // 
            // GroupGridView
            // 
            this.GroupGridView.MasterTemplate.AutoGenerateColumns = false;
            this.GroupGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 295;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "GroupName";
            gridViewTextBoxColumn1.HeaderText = "GroupName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "GroupName";
            gridViewTextBoxColumn1.Width = 295;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 294;
            this.GroupGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.GroupGridView.MasterTemplate.DataSource = this.groupsTbBindingSource;
            this.GroupGridView.Name = "GroupGridView";
            this.GroupGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupGridView.Size = new System.Drawing.Size(907, 315);
            this.GroupGridView.TabIndex = 2;
            this.GroupGridView.Text = "radGridView1";
            this.GroupGridView.ThemeName = "Office2013Light";
            this.GroupGridView.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.GroupGridView_CurrentRowChanged);
            // 
            // groupsTbBindingSource
            // 
            this.groupsTbBindingSource.DataSource = typeof(Ucas.Data.GroupsTb);
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
            this.EditBtn});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "العمليات";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // EditBtn
            // 
            this.EditBtn.AccessibleDescription = "radButtonElement2";
            this.EditBtn.AccessibleName = "radButtonElement2";
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Text = "radButtonElement2";
            this.EditBtn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // FrmGroupManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 662);
            this.Controls.Add(this.GroupGridView);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmGroupManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "radRibbonBar1";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmGroupManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescreptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView GroupGridView;
        private System.Windows.Forms.CheckedListBox PermssionList;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox DescreptionTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox GroupNameTextBox;
        private System.Windows.Forms.BindingSource groupsTbBindingSource;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement EditBtn;
    }
}

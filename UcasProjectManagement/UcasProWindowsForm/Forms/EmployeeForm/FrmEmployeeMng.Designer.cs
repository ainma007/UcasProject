namespace UcasProWindowsForm.Forms.EmployeeForm
{
    partial class FrmEmployeeMng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeMng));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.EmployeeGridView = new Telerik.WinControls.UI.RadGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(886, 145);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "radRibbonBar1";
            this.radRibbonBar1.ThemeName = "Office2013Light";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(886, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 561);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(886, 27);
            this.radStatusStrip1.TabIndex = 2;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2013Light";
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeGridView.Location = new System.Drawing.Point(0, 145);
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.MasterTemplate.AutoGenerateColumns = false;
            this.EmployeeGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 95;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "EmployeeName";
            gridViewTextBoxColumn1.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "EmployeeName";
            gridViewTextBoxColumn1.Width = 128;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "EmployeeGender";
            gridViewComboBoxColumn1.HeaderText = "الجنس";
            gridViewComboBoxColumn1.Name = "EmployeeGender";
            gridViewComboBoxColumn1.Width = 63;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "EmployeejobNumber";
            gridViewTextBoxColumn2.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "EmployeejobNumber";
            gridViewTextBoxColumn2.Width = 105;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PhoneNumber";
            gridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PhoneNumber";
            gridViewTextBoxColumn3.Width = 78;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Mobilenumber";
            gridViewTextBoxColumn4.HeaderText = "رقم الجوال";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Mobilenumber";
            gridViewTextBoxColumn4.Width = 78;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "EmployeeNationalNumber";
            gridViewTextBoxColumn6.HeaderText = "رقم الهوية";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "EmployeeNationalNumber";
            gridViewTextBoxColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn6.Width = 128;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "حفظ";
            gridViewCommandColumn1.Name = "EditBtn";
            gridViewCommandColumn1.Width = 51;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Name = "deltebtn";
            gridViewCommandColumn2.Width = 64;
            this.EmployeeGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.EmployeeGridView.MasterTemplate.DataSource = this.employeeBindingSource;
            sortDescriptor1.PropertyName = "EmployeeNationalNumber";
            this.EmployeeGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeGridView.Size = new System.Drawing.Size(886, 416);
            this.EmployeeGridView.TabIndex = 3;
            this.EmployeeGridView.Text = "radGridView1";
            this.EmployeeGridView.ThemeName = "Office2013Light";
            this.EmployeeGridView.EditorRequired += new Telerik.WinControls.UI.EditorRequiredEventHandler(this.EmployeeGridView_EditorRequired);
            this.EmployeeGridView.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.EmployeeGridView_CellValidating);
            this.EmployeeGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.EmployeeGridView_CellDoubleClick);
            this.EmployeeGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.EmployeeGridView_CommandCellClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Ucas.Data.Employee);
            // 
            // FrmEmployeeMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 630);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmEmployeeMng";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radRibbonBar1";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmEmployeeMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadGridView EmployeeGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

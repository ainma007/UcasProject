namespace UcasProWindowsForm.Forms.EmployeeForm
{
    partial class FrmAddEmployee
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.GenderDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.EmployeeNationalNumberTextBox4 = new Telerik.WinControls.UI.RadTextBox();
            this.EmailTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.MobilenumberTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.PhoneNumberTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.EmployeejobNumberTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.employeeNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNationalNumberTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobilenumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeejobNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(256, 45);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(77, 19);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "اسم الموظف:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Office2013Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(256, 72);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(42, 19);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "الجنس:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "Office2013Light";
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Location = new System.Drawing.Point(256, 99);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(82, 19);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "الرقم الوظيفي:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel6.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(221, 258);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 38);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // GenderDropDownList
            // 
            this.GenderDropDownList.AllowShowFocusCues = false;
            this.GenderDropDownList.AutoCompleteDisplayMember = null;
            this.GenderDropDownList.AutoCompleteValueMember = null;
            this.GenderDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "ذكر";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "انثى";
            radListDataItem2.TextWrap = true;
            this.GenderDropDownList.Items.Add(radListDataItem1);
            this.GenderDropDownList.Items.Add(radListDataItem2);
            this.GenderDropDownList.Location = new System.Drawing.Point(57, 72);
            this.GenderDropDownList.Name = "GenderDropDownList";
            // 
            // 
            // 
            this.GenderDropDownList.RootElement.StretchVertically = true;
            this.GenderDropDownList.Size = new System.Drawing.Size(193, 21);
            this.GenderDropDownList.TabIndex = 1;
            this.GenderDropDownList.ThemeName = "Office2013Light";
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Location = new System.Drawing.Point(256, 126);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(63, 19);
            this.radLabel3.TabIndex = 12;
            this.radLabel3.Text = "رقم الهاتف:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "Office2013Light";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Location = new System.Drawing.Point(256, 153);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 19);
            this.radLabel4.TabIndex = 14;
            this.radLabel4.Text = "رقم الجوال:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel4.ThemeName = "Office2013Light";
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.Location = new System.Drawing.Point(256, 180);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(90, 19);
            this.radLabel5.TabIndex = 16;
            this.radLabel5.Text = "البريد الالكتروني:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel5.ThemeName = "Office2013Light";
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Location = new System.Drawing.Point(256, 207);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(61, 19);
            this.radLabel7.TabIndex = 18;
            this.radLabel7.Text = "رقم الهوية:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel7.ThemeName = "Office2013Light";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.EmployeeNationalNumberTextBox4);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.EmailTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.MobilenumberTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.PhoneNumberTextBox);
            this.radGroupBox1.Controls.Add(this.GenderDropDownList);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.EmployeejobNumberTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.employeeNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "اضافة نشاط رئيسي";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(363, 310);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "اضافة نشاط رئيسي";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // EmployeeNationalNumberTextBox4
            // 
            this.EmployeeNationalNumberTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeNationalNumberTextBox4.Location = new System.Drawing.Point(57, 207);
            this.EmployeeNationalNumberTextBox4.Name = "EmployeeNationalNumberTextBox4";
            this.EmployeeNationalNumberTextBox4.Size = new System.Drawing.Size(193, 21);
            this.EmployeeNationalNumberTextBox4.TabIndex = 6;
            this.EmployeeNationalNumberTextBox4.ThemeName = "Office2013Light";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(57, 180);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(193, 21);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.ThemeName = "Office2013Light";
            // 
            // MobilenumberTextBox
            // 
            this.MobilenumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MobilenumberTextBox.Location = new System.Drawing.Point(57, 153);
            this.MobilenumberTextBox.Name = "MobilenumberTextBox";
            this.MobilenumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.MobilenumberTextBox.TabIndex = 4;
            this.MobilenumberTextBox.ThemeName = "Office2013Light";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(57, 126);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.PhoneNumberTextBox.TabIndex = 3;
            this.PhoneNumberTextBox.ThemeName = "Office2013Light";
            // 
            // EmployeejobNumberTextBox
            // 
            this.EmployeejobNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeejobNumberTextBox.Location = new System.Drawing.Point(57, 99);
            this.EmployeejobNumberTextBox.Name = "EmployeejobNumberTextBox";
            this.EmployeejobNumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.EmployeejobNumberTextBox.TabIndex = 2;
            this.EmployeejobNumberTextBox.ThemeName = "Office2013Light";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameTextBox.Location = new System.Drawing.Point(57, 45);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(193, 21);
            this.employeeNameTextBox.TabIndex = 0;
            this.employeeNameTextBox.ThemeName = "Office2013Light";
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 310);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmAddEmployee";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNationalNumberTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobilenumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeejobNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadDropDownList GenderDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox EmployeeNationalNumberTextBox4;
        private Telerik.WinControls.UI.RadTextBox EmailTextBox;
        private Telerik.WinControls.UI.RadTextBox MobilenumberTextBox;
        private Telerik.WinControls.UI.RadTextBox PhoneNumberTextBox;
        private Telerik.WinControls.UI.RadTextBox EmployeejobNumberTextBox;
        private Telerik.WinControls.UI.RadTextBox employeeNameTextBox;
    }
}

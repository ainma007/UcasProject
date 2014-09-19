namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class FrmAddGroup
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
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.PermssionList = new System.Windows.Forms.CheckedListBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.DescreptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.GroupNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.TheChecker = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescreptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.TheChecker);
            this.radGroupBox1.Controls.Add(this.PermssionList);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.DescreptionTextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.GroupNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "اضافة نشاط رئيسي";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(371, 491);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "اضافة نشاط رئيسي";
            this.radGroupBox1.ThemeName = "Office2013Light";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // PermssionList
            // 
            this.PermssionList.FormattingEnabled = true;
            this.PermssionList.Location = new System.Drawing.Point(15, 159);
            this.PermssionList.Name = "PermssionList";
            this.PermssionList.Size = new System.Drawing.Size(343, 244);
            this.PermssionList.TabIndex = 19;
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Location = new System.Drawing.Point(264, 84);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(77, 19);
            this.radLabel7.TabIndex = 18;
            this.radLabel7.Text = "وصف المجموعة:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel7.ThemeName = "Office2013Light";
            // 
            // DescreptionTextBox
            // 
            this.DescreptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescreptionTextBox.AutoSize = false;
            this.DescreptionTextBox.Location = new System.Drawing.Point(65, 84);
            this.DescreptionTextBox.Multiline = true;
            this.DescreptionTextBox.Name = "DescreptionTextBox";
            this.DescreptionTextBox.Size = new System.Drawing.Size(193, 50);
            this.DescreptionTextBox.TabIndex = 17;
            this.DescreptionTextBox.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(229, 431);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 38);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(264, 45);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 19);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "اسم المجموعة:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Office2013Light";
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNameTextBox.Location = new System.Drawing.Point(65, 45);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(193, 21);
            this.GroupNameTextBox.TabIndex = 0;
            this.GroupNameTextBox.ThemeName = "Office2013Light";
            // 
            // TheChecker
            // 
            this.TheChecker.AutoSize = true;
            this.TheChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TheChecker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheChecker.Location = new System.Drawing.Point(15, 431);
            this.TheChecker.Name = "TheChecker";
            this.TheChecker.Size = new System.Drawing.Size(175, 23);
            this.TheChecker.TabIndex = 20;
            this.TheChecker.Text = "تحـــديد  / ألغـــــاء تحديد الكل";
            this.TheChecker.UseVisualStyleBackColor = true;
            this.TheChecker.CheckedChanged += new System.EventHandler(this.TheChecker_CheckedChanged);
            // 
            // FrmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 491);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddGroup";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescreptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox DescreptionTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox GroupNameTextBox;
        private System.Windows.Forms.CheckedListBox PermssionList;
        private System.Windows.Forms.CheckBox TheChecker;
    }
}

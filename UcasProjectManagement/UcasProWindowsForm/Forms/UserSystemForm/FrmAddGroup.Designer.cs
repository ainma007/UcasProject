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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TheChecker = new System.Windows.Forms.CheckBox();
            this.PermssionList = new System.Windows.Forms.CheckedListBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.DescreptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.GroupNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
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
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.TheChecker);
            this.radGroupBox1.Controls.Add(this.PermssionList);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.DescreptionTextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.GroupNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "اضافة نشاط رئيسي";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(371, 468);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "اضافة نشاط رئيسي";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(304, 135);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 16);
            this.radLabel2.TabIndex = 19;
            this.radLabel2.Text = "الصلاحيات:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "TelerikMetro";
            // 
            // TheChecker
            // 
            this.TheChecker.AutoSize = true;
            this.TheChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TheChecker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheChecker.Location = new System.Drawing.Point(28, 427);
            this.TheChecker.Name = "TheChecker";
            this.TheChecker.Size = new System.Drawing.Size(175, 23);
            this.TheChecker.TabIndex = 20;
            this.TheChecker.Text = "تحـــديد  / ألغـــــاء تحديد الكل";
            this.TheChecker.UseVisualStyleBackColor = true;
            this.TheChecker.CheckedChanged += new System.EventHandler(this.TheChecker_CheckedChanged);
            // 
            // PermssionList
            // 
            this.PermssionList.FormattingEnabled = true;
            this.PermssionList.Location = new System.Drawing.Point(19, 157);
            this.PermssionList.Name = "PermssionList";
            this.PermssionList.Size = new System.Drawing.Size(343, 244);
            this.PermssionList.TabIndex = 2;
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Location = new System.Drawing.Point(278, 79);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(80, 16);
            this.radLabel7.TabIndex = 18;
            this.radLabel7.Text = "وصف المجموعة:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel7.ThemeName = "TelerikMetro";
            // 
            // DescreptionTextBox
            // 
            this.DescreptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescreptionTextBox.AutoSize = false;
            this.DescreptionTextBox.Location = new System.Drawing.Point(43, 75);
            this.DescreptionTextBox.Multiline = true;
            this.DescreptionTextBox.Name = "DescreptionTextBox";
            this.DescreptionTextBox.Size = new System.Drawing.Size(234, 50);
            this.DescreptionTextBox.TabIndex = 1;
            this.DescreptionTextBox.ThemeName = "TelerikMetro";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(229, 419);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 38);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "TelerikMetro";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(279, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 16);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "اسم المجموعة:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "TelerikMetro";
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNameTextBox.Location = new System.Drawing.Point(43, 37);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.GroupNameTextBox.TabIndex = 0;
            this.GroupNameTextBox.ThemeName = "TelerikMetro";
            // 
            // FrmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 468);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 503);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 503);
            this.Name = "FrmAddGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(379, 503);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة المجموعة";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FrmAddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescreptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox DescreptionTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox GroupNameTextBox;
        private System.Windows.Forms.CheckedListBox PermssionList;
        private System.Windows.Forms.CheckBox TheChecker;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}

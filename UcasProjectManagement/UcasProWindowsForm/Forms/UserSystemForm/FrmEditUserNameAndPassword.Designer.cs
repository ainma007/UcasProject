﻿namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class FrmEditUserNameAndPassword
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.NewuserNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.OldPasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.NewpasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewuserNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewpasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.NewpasswordTextBox);
            this.radGroupBox1.Controls.Add(this.OldPasswordTextBox);
            this.radGroupBox1.Controls.Add(this.NewuserNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(386, 230);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // NewuserNameTextBox
            // 
            this.NewuserNameTextBox.Location = new System.Drawing.Point(39, 86);
            this.NewuserNameTextBox.Name = "NewuserNameTextBox";
            this.NewuserNameTextBox.Size = new System.Drawing.Size(221, 22);
            this.NewuserNameTextBox.TabIndex = 0;
            this.NewuserNameTextBox.ThemeName = "TelerikMetro";
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Location = new System.Drawing.Point(39, 31);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(221, 22);
            this.OldPasswordTextBox.TabIndex = 1;
            this.OldPasswordTextBox.ThemeName = "TelerikMetro";
            // 
            // NewpasswordTextBox
            // 
            this.NewpasswordTextBox.Location = new System.Drawing.Point(39, 114);
            this.NewpasswordTextBox.Name = "NewpasswordTextBox";
            this.NewpasswordTextBox.Size = new System.Drawing.Size(221, 22);
            this.NewpasswordTextBox.TabIndex = 2;
            this.NewpasswordTextBox.ThemeName = "TelerikMetro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم المستخدم الجديد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "كلمة المرور القديمة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمة المرور الجديدة";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(234, 178);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 36);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "حفظ التعديلات";
            this.SaveBtn.ThemeName = "TelerikMetro";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditUserNameAndPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 230);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmEditUserNameAndPassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditUserNameAndPassword";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FrmEditUserNameAndPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewuserNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewpasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox NewpasswordTextBox;
        private Telerik.WinControls.UI.RadTextBox OldPasswordTextBox;
        private Telerik.WinControls.UI.RadTextBox NewuserNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

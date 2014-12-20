namespace UcasProWindowsForm.Forms.Attachments
{
    partial class FrmAddAttachments
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(83, 28);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(278, 22);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.ThemeName = "TelerikMetro";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(17, 28);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(60, 22);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "...";
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(251, 68);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 37);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "رفع الملف";
            this.SaveBtn.ThemeName = "TelerikMetro";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(6, 118);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(277, 24);
            this.radWaitingBar1.TabIndex = 3;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "TelerikMetro";
            this.radWaitingBar1.Visible = false;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 122);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "جاري رفع الملف..";
            this.label1.Visible = false;
            // 
            // FrmAddAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBox1);
            this.Name = "FrmAddAttachments";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " رفع ملف ";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddAttachments_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private System.Windows.Forms.Label label1;
    }
}

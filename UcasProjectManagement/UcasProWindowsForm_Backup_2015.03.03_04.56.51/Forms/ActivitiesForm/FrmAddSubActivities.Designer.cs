namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    partial class FrmAddSubActivities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSubActivities));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Coinlabel = new System.Windows.Forms.Label();
            this.SubActivitiesDescriptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.TotalCostTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.EndDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.StartDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.SubActivitiesNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.ActvitesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivitiesDescriptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCostTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivitiesNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ActvitesTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.Coinlabel);
            this.radGroupBox1.Controls.Add(this.SubActivitiesDescriptionTextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.TotalCostTextBox);
            this.radGroupBox1.Controls.Add(this.EndDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.StartDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.SubActivitiesNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "بيانات الادخال";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(352, 285);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "بيانات الادخال";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // Coinlabel
            // 
            this.Coinlabel.ForeColor = System.Drawing.Color.Green;
            this.Coinlabel.Location = new System.Drawing.Point(59, 205);
            this.Coinlabel.Name = "Coinlabel";
            this.Coinlabel.Size = new System.Drawing.Size(100, 19);
            this.Coinlabel.TabIndex = 12;
            this.Coinlabel.Text = "-";
            // 
            // SubActivitiesDescriptionTextBox
            // 
            this.SubActivitiesDescriptionTextBox.AutoSize = false;
            this.SubActivitiesDescriptionTextBox.Location = new System.Drawing.Point(19, 80);
            this.SubActivitiesDescriptionTextBox.Multiline = true;
            this.SubActivitiesDescriptionTextBox.Name = "SubActivitiesDescriptionTextBox";
            this.SubActivitiesDescriptionTextBox.Size = new System.Drawing.Size(228, 54);
            this.SubActivitiesDescriptionTextBox.TabIndex = 2;
            this.SubActivitiesDescriptionTextBox.ThemeName = "TelerikMetro";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(213, 236);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(127, 44);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "اضافة السجل";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "TelerikMetro";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Location = new System.Drawing.Point(245, 201);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(86, 18);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "المبلغ المخصص:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalCostTextBox.Location = new System.Drawing.Point(163, 201);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalCostTextBox.Size = new System.Drawing.Size(81, 22);
            this.TotalCostTextBox.TabIndex = 5;
            this.TotalCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalCostTextBox.ThemeName = "TelerikMetro";
            this.TotalCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalCostTextBox_KeyPress);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(141, 172);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDateTimePicker.Size = new System.Drawing.Size(103, 22);
            this.EndDateTimePicker.TabIndex = 4;
            this.EndDateTimePicker.TabStop = false;
            this.EndDateTimePicker.Text = "15/09/2014";
            this.EndDateTimePicker.ThemeName = "TelerikMetro";
            this.EndDateTimePicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Location = new System.Drawing.Point(250, 170);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "تاريخ الانتهاء:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(141, 141);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDateTimePicker.Size = new System.Drawing.Size(103, 22);
            this.StartDateTimePicker.TabIndex = 3;
            this.StartDateTimePicker.TabStop = false;
            this.StartDateTimePicker.Text = "15/09/2014";
            this.StartDateTimePicker.ThemeName = "TelerikMetro";
            this.StartDateTimePicker.Value = new System.DateTime(2014, 9, 15, 17, 54, 37, 444);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Location = new System.Drawing.Point(250, 141);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(55, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "تاريخ البدء:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(251, 83);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(72, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "وصف النشاط:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(250, 53);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "اسم النشاط الفرعي:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // SubActivitiesNameTextBox
            // 
            this.SubActivitiesNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubActivitiesNameTextBox.Location = new System.Drawing.Point(19, 51);
            this.SubActivitiesNameTextBox.Name = "SubActivitiesNameTextBox";
            this.SubActivitiesNameTextBox.Size = new System.Drawing.Size(228, 22);
            this.SubActivitiesNameTextBox.TabIndex = 1;
            this.SubActivitiesNameTextBox.ThemeName = "TelerikMetro";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.ForeColor = System.Drawing.Color.Red;
            this.radLabel5.Location = new System.Drawing.Point(251, 21);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(78, 18);
            this.radLabel5.TabIndex = 13;
            this.radLabel5.Text = "النشاط الرئيسي:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ActvitesTextBox
            // 
            this.ActvitesTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ActvitesTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActvitesTextBox.ForeColor = System.Drawing.Color.Red;
            this.ActvitesTextBox.Location = new System.Drawing.Point(19, 19);
            this.ActvitesTextBox.Name = "ActvitesTextBox";
            this.ActvitesTextBox.ReadOnly = true;
            this.ActvitesTextBox.Size = new System.Drawing.Size(228, 21);
            this.ActvitesTextBox.TabIndex = 0;
            this.ActvitesTextBox.TabStop = false;
            // 
            // FrmAddSubActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 285);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "FrmAddSubActivities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(360, 320);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة نشاط فرعي";
            this.ThemeName = "TelerikMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddSubActivities_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddSubActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivitiesDescriptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCostTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivitiesNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox TotalCostTextBox;
        private Telerik.WinControls.UI.RadDateTimePicker EndDateTimePicker;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker StartDateTimePicker;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox SubActivitiesNameTextBox;
        private Telerik.WinControls.UI.RadTextBox SubActivitiesDescriptionTextBox;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Coinlabel;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.TextBox ActvitesTextBox;

    }
}

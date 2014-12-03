namespace UcasProWindowsForm.Forms.UserSystemForm
{
    partial class frmUserManage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.UserGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGridView
            // 
            this.UserGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.UserGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UserGridView.ForeColor = System.Drawing.Color.Black;
            this.UserGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // UserGridView
            // 
            this.UserGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 64;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Employee.EmployeeName";
            gridViewTextBoxColumn2.HeaderText = "EmployeeName";
            gridViewTextBoxColumn2.Name = "EmployeeName";
            gridViewTextBoxColumn2.Width = 170;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "UserName";
            gridViewTextBoxColumn3.HeaderText = "UserName";
            gridViewTextBoxColumn3.Name = "UserName";
            gridViewTextBoxColumn3.Width = 165;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Password";
            gridViewTextBoxColumn4.HeaderText = "Password";
            gridViewTextBoxColumn4.Name = "Password";
            gridViewTextBoxColumn4.Width = 194;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "TypeUser";
            gridViewComboBoxColumn1.HeaderText = "TypeUser";
            gridViewComboBoxColumn1.Name = "TypeUser";
            gridViewComboBoxColumn1.Width = 106;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Savebtn";
            gridViewCommandColumn1.Name = "Savebtn";
            gridViewCommandColumn1.Width = 66;
            this.UserGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn1,
            gridViewCommandColumn1});
            sortDescriptor1.PropertyName = "ID";
            this.UserGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserGridView.Size = new System.Drawing.Size(780, 482);
            this.UserGridView.TabIndex = 1;
            this.UserGridView.Text = "radGridView2";
            this.UserGridView.ThemeName = "TelerikMetro";
            this.UserGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.UserGridView_CommandCellClick);
            this.UserGridView.Click += new System.EventHandler(this.UserGridView_Click);
            // 
            // frmUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 482);
            this.Controls.Add(this.UserGridView);
            this.Name = "frmUserManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "igrdj";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frmUserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView UserGridView;


    }
}

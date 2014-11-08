using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Forms.supplierForm;



namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmAdmin : Telerik.WinControls.UI.RadForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
           
        }
        ProjectProfileCmd cmd = new ProjectProfileCmd();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            projectProfileBindingSource.DataSource = ProjectProfileCmd.GetAllProjects();
           
        }



        private void ProjectAddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddProject AddPro = new FrmAddProject();
            AddPro.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void GroupMangBtn_Click(object sender, EventArgs e)
        {
          

        }

    

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddEmployee addempfrm = new FrmAddEmployee();
            addempfrm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void ProjectMangBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmProjectManage ProMang = new FrmProjectManage();
            ProMang.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void SuppAddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddsupplier addSup = new FrmAddsupplier();
            addSup.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void FinanAddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddTheTheDonors finadd = new FrmAddTheTheDonors();
            finadd.ShowDialog();
            this.Cursor = Cursors.Default;

        }

     

        private void FrmAdmin_Activated(object sender, EventArgs e)
        {
          //  FrmAdmin_Load(sender, e);
        }

        private void GroupAddBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void FinanMangBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmManagementTheDonors finamang = new FrmManagementTheDonors();
            finamang.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void EmployeeMangBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmEmployeeMng empmang = new FrmEmployeeMng();
            empmang.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmMainUserPro user = new FrmMainUserPro();
            int XProId = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());
            var ListData = ProjectProfileCmd.GetProjectData(XProId);
            
            foreach (var item in ListData)
            {
                InformationsClass.ProjID = item.ID;
                user.radTextBox1.Text = item.ProjectName;
                user.DescTextBox.Text = item.ProjectDescription;
                user.StartDateTextBox.Text = item.StartDate.ToString();
                user.EndDateTextBox.Text = item.EndDate.ToString();
                user.radTextBox2.Text = item.TotalCost.ToString();
                user.radTextBox3.Text = item.Coin.ToString();

            }
            user.ShowDialog();

            this.Cursor = Cursors.Default;
        }

     

        private void SupmanageBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmManagementSupplier MangSup = new FrmManagementSupplier();
            MangSup.ShowDialog();
            this.Cursor = Cursors.Default;
        }

       
    }
}

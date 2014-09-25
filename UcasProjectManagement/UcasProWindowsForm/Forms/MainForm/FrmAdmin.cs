using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Forms.supplierForm;
using UcasProWindowsForm.Forms.UserSystemForm ;


namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmAdmin : Telerik.WinControls.UI.RadForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
           
        }
        ProjectProfileCmd cmd = new ProjectProfileCmd();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            projectProfileBindingSource.DataSource = ProjectProfileCmd.GetAllProjects();
        }

        private void ProjectAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProject AddPro = new FrmAddProject();
            AddPro.ShowDialog();
        }

        private void GroupMangBtn_Click(object sender, EventArgs e)
        {
            FrmGroupManage mangfrm = new FrmGroupManage();
            mangfrm.ShowDialog();
        }

    

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addempfrm = new FrmAddEmployee();
            addempfrm.ShowDialog();
        }

        private void ProjectMangBtn_Click(object sender, EventArgs e)
        {
            FrmProjectManage ProMang = new FrmProjectManage();
            ProMang.ShowDialog();
        }

        private void SuppAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddsupplier addSup = new FrmAddsupplier();
            addSup.ShowDialog();
        }

        private void FinanAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddTheTheDonors finadd = new FrmAddTheTheDonors();
            finadd.ShowDialog();
        }

        private void SuppMangBtn_Click(object sender, EventArgs e)
        {
            FrmManagementSupplier MangSup = new FrmManagementSupplier();
            MangSup.ShowDialog();
        }

        private void FrmAdmin_Activated(object sender, EventArgs e)
        {
          //  FrmAdmin_Load(sender, e);
        }

        private void GroupAddBtn_Click(object sender, EventArgs e)
        {

            Form frm = new FrmAddGroup();
            frm.Show();
        }

        private void FinanMangBtn_Click(object sender, EventArgs e)
        {
            FrmManagementTheDonors finamang = new FrmManagementTheDonors();
            finamang.ShowDialog();
        }

        private void EmployeeMangBtn_Click(object sender, EventArgs e)
        {
            FrmEmployeeMng empmang = new FrmEmployeeMng();
            empmang.ShowDialog();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            FrmMainUserPro user = new FrmMainUserPro();
            int XProId = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());
            var ListData = ProjectProfileCmd.GetProjectData(XProId);
            
            foreach (var item in ListData)
            {
                PeremissionsHolderClass.ProjID = item.ID;
                user.radTextBox1.Text = item.ProjectName;
                user.DescTextBox.Text = item.ProjectDescription;
                user.StartDateTextBox.Text = item.StartDate.ToString();
                user.EndDateTextBox.Text = item.EndDate.ToString();
                user.radTextBox2.Text = item.TotalCost.ToString();
                user.radTextBox3.Text = item.Coin.ToString();

            }
            user.ShowDialog();

          //  MessageBox.Show("" + XProId);
        }

        private void UserAddBtn_Click(object sender, EventArgs e)
        {
           //
            Form frm = new frmAddUser();
          
          frm.ShowDialog();
          

        }

        private void UserMangBtn_Click(object sender, EventArgs e)
        {
            FrmUserManagment userM = new FrmUserManagment();
            userM.ShowDialog();
        }
    }
}

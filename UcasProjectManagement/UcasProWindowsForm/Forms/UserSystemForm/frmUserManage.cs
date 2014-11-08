using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class frmUserManage : Telerik.WinControls.UI.RadForm
    {
        public frmUserManage()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUserManage_Load(object sender, EventArgs e)
        {
            UserGridView.DataSource = UsersCmd.GetAllUsers();
        }

        private void UserGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col2 = UserGridView.CurrentColumn.Index;

             if (col2 == 5)
             {
                 frmUserEdit frm= new frmUserEdit();
                 Ucas.Data.UserTb usr =( Ucas.Data.UserTb) UserGridView.CurrentRow.DataBoundItem;
                 frm.TragetUser = usr;
                 //frm.XUserId = int.Parse(UserGridView.CurrentRow.Cells[0].Value.ToString());
                 //frm.employeeNameTextBox.Text = UserGridView.CurrentRow.Cells[1].Value.ToString();
                 //frm.UserNameTextBox.Text = UserGridView.CurrentRow.Cells[2].Value.ToString();
                 //frm.PasswordTextBox.Text = UserGridView.CurrentRow.Cells[3].Value.ToString();
                 frm.ShowDialog();
             }
        }

        private void UserGridView_Click(object sender, EventArgs e)
        {

        }
    }
}

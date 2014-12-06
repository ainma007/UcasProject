using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
            Thread th = new Thread(fillData);
            th.Start();
           
        }

        private void fillData()
        {

            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = UsersCmd.GetAllUsers();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                UserGridView.DataSource = q;
                StatusLabel1.Text = "";

            });
        }

        private void UserGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col2 = UserGridView.CurrentColumn.Index;

             if (col2 == 5)
             {
                 frmUserEdit frm= new frmUserEdit();
                 Ucas.Data.UserTb usr =( Ucas.Data.UserTb) UserGridView.CurrentRow.DataBoundItem;
                 frm.TragetUser = usr;
                 
                 frm.ShowDialog();
                 frm.Dispose();
             }
        }

        private void UserGridView_Click(object sender, EventArgs e)
        {

        }
    }
}

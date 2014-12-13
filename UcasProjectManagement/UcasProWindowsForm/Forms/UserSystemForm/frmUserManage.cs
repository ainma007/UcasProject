using System;
using System.Threading;
using System.Windows.Forms;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class frmUserManage : Telerik.WinControls.UI.RadForm
    {
        public frmUserManage()
        {
            InitializeComponent();
        }


        Thread th;
        private void frmUserManage_Load(object sender, EventArgs e)
        {
           
            th = new Thread(fillData);
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
            th.Abort();
        }

        private void UserGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col2 = UserGridView.CurrentColumn.Index;

             if (col2 == 5)
             {
                 Operation.BeginOperation(this);
                 frmUserEdit frm= new frmUserEdit();
                 Ucas.Data.UserTb usr =( Ucas.Data.UserTb) UserGridView.CurrentRow.DataBoundItem;
                 frm.TragetUser = usr;
                 
                 frm.ShowDialog();
                 Operation.EndOperation(this);
                 frmUserManage_Load(null, null);
             }
        }

        private void UserGridView_Click(object sender, EventArgs e)
        {

        }

        private void frmUserManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

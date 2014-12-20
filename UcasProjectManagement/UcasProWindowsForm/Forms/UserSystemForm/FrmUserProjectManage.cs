using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmUserProjectManage : Telerik.WinControls.UI.RadForm
    {
        public FrmUserProjectManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void FrmUserProjectManage_Load(object sender, EventArgs e)
        {
            th = new Thread(FillData);
            th.Start();
           
          
        }

        private void FillData()
        {
            Operation.BeginOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";
            });

            Application.DoEvents();
            var q = ProjectControlCmd.GetAllProControls();
            Application.DoEvents();
           

         
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                ProjectControlGridView.DataSource = q;
                toolStripStatusLabel1.Text = "";
            });
            Operation.EndOperation(this);
            th.Abort(); 
        }

        private void ProjectControlGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProjectControlGridView.CurrentColumn.Index;
            if (col == 4)
            {
                Operation.BeginOperation(this);
               

                FrmEditUserToProject frm = new FrmEditUserToProject();
                Ucas.Data.ProjectControl tb = (Ucas.Data.ProjectControl)ProjectControlGridView.CurrentRow.DataBoundItem;
                frm.TragetProjectControl = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
                FrmUserProjectManage_Load(null, null);

            }
        }

        private void FrmUserProjectManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

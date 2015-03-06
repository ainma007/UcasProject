using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;
using System.Drawing;

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
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
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
            if (col == 5)
            {
                Operation.BeginOperation(this);
               

                FrmEditUserToProject frm = new FrmEditUserToProject();
                Ucas.Data.ProjectControl tb = (Ucas.Data.ProjectControl)ProjectControlGridView.CurrentRow.DataBoundItem;
                frm.TragetProjectControl = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
                FrmUserProjectManage_Load(null, null);

            }

            if (col == 6)
            {


                if (RadMessageBox.Show(OperationX.DeleteMessage, "حذف", MessageBoxButtons.YesNo,RadMessageIcon.Info) == System.Windows.Forms.DialogResult.Yes)
                {
                    Operation.BeginOperation(this);

                    ProjectControlCmd.DeleteProControl(((ProjectControl)ProjectControlGridView.CurrentRow.DataBoundItem).ID);
                    Operation.ShowToustOk(OperationX.DeletedMessage, this);
                    FrmUserProjectManage_Load(null, null);
                    Operation.EndOperation(this);
                }

            }
        }

        private void FrmUserProjectManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddUserToProject frm = new FrmAddUserToProject();
            frm.ShowDialog();
            FrmUserProjectManage_Load(null, null);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmUserProjectManage_Load(null, null);

        }
    }
}

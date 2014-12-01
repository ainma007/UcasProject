using System;
using System.Windows.Forms;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmUserProjectManage : Telerik.WinControls.UI.RadForm
    {
        public FrmUserProjectManage()
        {
            InitializeComponent();
        }

        private void FrmUserProjectManage_Load(object sender, EventArgs e)
        {
            FillData();
          
        }

        private void FillData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";
            });

            Operation.BeginOperation(this);
            ProjectControlGridView.DataSource = ProjectControlCmd.GetAllProControls();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "";
            });
        }

        private void ProjectControlGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProjectControlGridView.CurrentColumn.Index;
            if (col == 4)
            {
                this.Cursor = Cursors.WaitCursor;
                FrmEditUserToProject frm = new FrmEditUserToProject();
                frm.FillComboBox();
                Ucas.Data.ProjectControl tb = (Ucas.Data.ProjectControl)ProjectControlGridView.CurrentRow.DataBoundItem;
                frm.TragetProjectControl = tb;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;


            }
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.MainForm;
using System.Drawing;


namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmTheDonorsAndProjectManage : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }


        Thread th;
        private void AddDonorsBtn_Click(object sender, EventArgs e)
        {
            if (InformationsClass.Coordinator == 0)
            {
                RadMessageBox.Show("غير مصرحة لك الصلاحية", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;

            }
            Operation.BeginOperation(this);
            FrmTheDonorsAndProjectAdd frm = new FrmTheDonorsAndProjectAdd();
            frm.ShowDialog();
            Operation.EndOperation(this);
            FrmTheDonorsAndProjectManage_Load(null, null);
        }

        private void FrmTheDonorsAndProjectManage_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(FillData);
            th.Start();
           
         
        }

        private void FillData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = TheDonorsProjectCmd.GetAllDonorsByproID(InformationsClass.ProjID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                radGridView1.DataSource = q;
                StatusLabel1.Text = "";

            });
            th.Abort();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            if (InformationsClass.Coordinator == 0)
            {
                RadMessageBox.Show("غير مصرحة لك الصلاحية", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;

            }
            var col = radGridView1.CurrentColumn.Index;
            if (col == 3)
            {
                Operation.BeginOperation(this);
                FrmTheDonorsAndProjectEdit frm = new FrmTheDonorsAndProjectEdit();
                Ucas.Data.TheDonorsProject db = (Ucas.Data.TheDonorsProject)radGridView1.CurrentRow.DataBoundItem;
                frm.TragetTheDonorsProject = db;
                Operation.EndOperation(this);
                frm.ShowDialog();
                FrmTheDonorsAndProjectManage_Load(null, null);
            }
            if (col == 4)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    

                    if (TheDonorsProjectCmd.DeleteDonorsProject(int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString())))
                    {
                        FrmTheDonorsAndProjectManage_Load(null, null);
                        Operation.ShowToustOk(OperationX.DeletedMessage, this);
                        Operation.EndOperation(this);
                     
                    }

                    else
                    {
                        Operation.EndOperation(this);
                        RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                    }
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FrmTheDonorsAndProjectManage_Load(null, null);
            this.Cursor = Cursors.Default;

        }

        private void FrmTheDonorsAndProjectManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmProjectManage : Telerik.WinControls.UI.RadForm
    {
        public FrmProjectManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void FrmProjectManage_Load(object sender, EventArgs e)
        {
            
            th = new Thread(GetAllProject);
            th.Start();

       }
       
        private void GetAllProject()
        {
            
           
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = ProjectProfileCmd.GetAllProjects(); ;
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                ProjectProfileGridView.DataSource = q;
                StatusLabel1.Text = "";

            });
            th.Abort();
        }
   
   

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProjectProfileGridView.CurrentColumn.Index;
            if (col == 9)
            {
                Operation.BeginOperation(this);
               

                FrmEditProject frm = new FrmEditProject();

                Ucas.Data.ProjectProfile db = (Ucas.Data.ProjectProfile)ProjectProfileGridView.CurrentRow.DataBoundItem;
                frm.TragetProject = db;
                frm.ShowDialog();
                Operation.EndOperation(this);
                this.FrmProjectManage_Load(null, null);
            }

                if (col == 10)
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "حذف سجل", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                    {
                        Operation.BeginOperation(this);

                        if (ProjectProfileCmd.DeleteProjectProfile(int.Parse(ProjectProfileGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                             Operation.EndOperation(this);
                             this.FrmProjectManage_Load(null, null);
                             Operation.ShowToustOk(OperationX.DeletedMessage, this);
                            

                           
                        }
                        else
                        {
                            Operation.EndOperation(this);
                            RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);


                        }
                       
                    }
                    

                }
            }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddProject frm = new FrmAddProject();
            frm.ShowDialog();
            Operation.EndOperation(this);
            this.FrmProjectManage_Load(null, null);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
          

            this.FrmProjectManage_Load(null, null);
            this.Cursor = Cursors.Default;
          

        }

        private void FrmProjectManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

       


        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data;
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

        private void FrmProjectManage_Load(object sender, EventArgs e)
        {
           
            GetAllProject();
           
        }
       
        private void GetAllProject()
        {
            ProjectbindingSource.DataSource = ProjectProfileCmd.GetAllProjects();

        }
   
   

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProjectProfileGridView.CurrentColumn.Index;
            if (col == 9)
            {
                this.Cursor = Cursors.WaitCursor;
              

                FrmEditProject frm = new FrmEditProject();

                Ucas.Data.ProjectProfile db = (Ucas.Data.ProjectProfile)ProjectProfileGridView.CurrentRow.DataBoundItem;
                frm.TragetProject = db;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }

                if (col == 10)
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "حذف سجل", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                    {
                        Operation.BeginOperation(this);
                        

                        ProjectProfile cp = ProjectbindingSource.Current as ProjectProfile;
                        ProjectProfileCmd.DeleteProjectProfile(cp.ID);
                        GetAllProject();
                        Operation.EndOperation(this);
                        RadMessageBox.Show(OperationX.DeletedMessage, "نجاح العملية", MessageBoxButtons.OK);
                    }
                    

                }
            }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            

            FrmAddProject frm = new FrmAddProject();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmProjectManage_Load(sender, e);
            this.Cursor = Cursors.Default;

        }

       


        }
    }


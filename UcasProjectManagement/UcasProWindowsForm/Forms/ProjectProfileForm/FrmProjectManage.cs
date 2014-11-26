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
                FrmEditProject frm = new FrmEditProject();

                Ucas.Data.ProjectProfile db = (Ucas.Data.ProjectProfile)ProjectProfileGridView.CurrentRow.DataBoundItem;
                frm.TragetProject = db;
                frm.ShowDialog();
            }

                if (col == 10)
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                    {
                        ProjectProfile cp = ProjectbindingSource.Current as ProjectProfile;
                        ProjectProfileCmd.DeleteProjectProfile(cp.ID);
                        GetAllProject();
                    }
                    

                }
            }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProject frm = new FrmAddProject();
            frm.ShowDialog();
        }

       


        }
    }


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
            RadMessageBox.SetThemeName("Office2013Light");
        }

        private void FrmProjectManage_Load(object sender, EventArgs e)
        {
            FillCombo();
            GetAllProject();
            LockGrid();
           
        }
        private void FillCombo()
        {

            string[] s = { "شيكل", "دينار اردني", "دولار امريكي", "يورو" };

            //--- Get Coloumn From Grid
            GridViewComboBoxColumn Col = (GridViewComboBoxColumn)radGridView1.Columns["Coin"];
            Col.DataSource = s;


            // Create Sourrce Here
            string[] s1 = { "فعال", "غير فعال" };

            //--- Get Coloumn From Grid
            GridViewComboBoxColumn Col2 = (GridViewComboBoxColumn)radGridView1.Columns["Status"];
            Col2.DataSource = s1;
        }
        private void LockGrid()
        {
            for (int i = 0; i <= radGridView1.Rows.Count - 1; i++)
            {
                radGridView1.Rows[i].Cells[0].ReadOnly = true;
                radGridView1.Rows[i].Cells[1].ReadOnly = true;
                radGridView1.Rows[i].Cells[2].ReadOnly = true;
                radGridView1.Rows[i].Cells[3].ReadOnly = true;
                radGridView1.Rows[i].Cells[4].ReadOnly = true;
                radGridView1.Rows[i].Cells[5].ReadOnly = true;
                radGridView1.Rows[i].Cells[6].ReadOnly = true;
                radGridView1.Rows[i].Cells[7].ReadOnly = true;
                radGridView1.Rows[i].Cells[8].ReadOnly = true;


            }

        }
        private void GetAllProject()
        {
            ProjectbindingSource.DataSource = ProjectProfileCmd.GetAllProjects();

        }
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
            ////Clear Old Data
            //db.ProjectProfiles = null;
            
            ////Load New Data
            //db.ProjectProfiles.AddRange(ls);
            //db.SaveChanges();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
        
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;
            if (col == 9)
            {
                if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                {
                    ProjectProfile cp = ProjectbindingSource.Current as ProjectProfile;
                    ProjectProfileCmd.EditProjectProfile(cp);
                    GetAllProject();
                    LockGrid();
                }
                else
                {

                    GetAllProject();
                    LockGrid();
                }

                if (col == 10)
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                    {
                        ProjectProfile cp = ProjectbindingSource.Current as ProjectProfile;
                        ProjectProfileCmd.DeleteProjectProfile(cp.ID);
                        GetAllProject();
                        LockGrid();
                    }
                    

                }
            }

        }

        private void MasterTemplate_CellClick(object sender, GridViewCellEventArgs e)
        {
            
            
           
        }

        private void MasterTemplate_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
                radGridView1.Rows[e.RowIndex].Cells[0].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[1].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[5].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[6].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[7].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[8].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[9].ReadOnly = false;
                radGridView1.Rows[e.RowIndex].Cells[10].ReadOnly = false;



            }

        private void MasterTemplate_ValueChanged(object sender, EventArgs e)
        {
           
        }
        }
    }


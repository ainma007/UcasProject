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
            FillCombo();
            GetAllProject();
           
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
                FrmEditProject frm = new FrmEditProject();
                frm.XProID =int.Parse( radGridView1.CurrentRow.Cells[0].Value.ToString());
                frm.ProjectNameTextBox.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.ProjectDescriptionTextBox.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.StartDateTimePicker.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.EndDateTimePicker.Text = radGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.TotalCostTextBox.Text = radGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.CoineDropDownList.Text = radGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.StatusDownList.Text = radGridView1.CurrentRow.Cells[8].Value.ToString();
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

       

        private void MasterTemplate_CellClick(object sender, GridViewCellEventArgs e)
        {
            
            
           
        }

        private void MasterTemplate_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
               


      }

        private void MasterTemplate_ValueChanged(object sender, EventArgs e)
        {
           
        }
        }
    }


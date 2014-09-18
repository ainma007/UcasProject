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
        }

        private void FrmProjectManage_Load(object sender, EventArgs e)
        {
            // Create Sourrce Here
            string[] s = {"Abu Ehab","samer","Mohammed"};

            //--- Get Coloumn From Grid
            GridViewComboBoxColumn Col = (GridViewComboBoxColumn)radGridView1.Columns["Coin"];
            Col.DataSource = s;

            //-- FilData Grid
            ls = ProjectProfileCmd.GetAllProjects();
            ProjectbindingSource.DataSource = ls;
        }

        List<ProjectProfile> ls = new List<ProjectProfile>();
        UcasProEntities db = new UcasProEntities();
       
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
            //Clear Old Data
            db.ProjectProfiles = null;
            
            //Load New Data
            db.ProjectProfiles.AddRange(ls);
            db.SaveChanges();
        }
    }
}

﻿using System;
using System.Windows.Forms;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.ActivitiesForm;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmMainUserPro : Telerik.WinControls.UI.RadForm
    {
        public FrmMainUserPro()
        {
            InitializeComponent();
        }

        int ProID = ProjectControlCmd.ChkProjectIDByUserID(InformationsClass.xCurrentUserID);
        private void FrmMainUserPro_Load(object sender, EventArgs e)
        {
            var ListData = ProjectProfileCmd.GetProjectData(ProID);
            foreach (var item in ListData )
            {
                InformationsClass.ProjID = item.ID;
                this.radTextBox1.Text = item.ProjectName;
                this.DescTextBox.Text = item.ProjectDescription;
                this.StartDateTextBox.Text = item.StartDate.ToString ();
                this.EndDateTextBox.Text = item.EndDate.ToString ();
                this.radTextBox2.Text = item.TotalCost.ToString ();
                this.radTextBox3.Text = item.Coin.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTheDonorsAndProjectAdd frm = new FrmTheDonorsAndProjectAdd();
            frm.ShowDialog();
        }

        private void ProjectManageBtn_Click(object sender, EventArgs e)
        {
            FrmOneProjectProfileManage proMange = new FrmOneProjectProfileManage();
            proMange.ShowDialog();
        }

        private void ContractsBtn_Click(object sender, EventArgs e)
        {
            FrmContratsManage ContrMng = new FrmContratsManage();
            ContrMng.ShowDialog();
        }

        private void FrmMainUserPro_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Dispose();
            

           
        }

        private void ActivitesBtn_Click(object sender, EventArgs e)
        {
            FrmAllActivitesMange Activfrm = new FrmAllActivitesMange();
            Activfrm.ShowDialog();
        }
    }
}

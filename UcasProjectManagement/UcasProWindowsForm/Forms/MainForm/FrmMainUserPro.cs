using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;
namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmMainUserPro : Telerik.WinControls.UI.RadForm
    {
        public FrmMainUserPro()
        {
            InitializeComponent();
        }

        int ProID = ProjectControlCmd.ChkProjectIDByUserID(PeremissionsHolderClass.xCurrentUserID);
        private void FrmMainUserPro_Load(object sender, EventArgs e)
        {
            var ListData = ProjectProfileCmd.GetProjectData(ProID);
            foreach (var item in ListData )
            {
                PeremissionsHolderClass.ProjID = item.ID;
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
    }
}

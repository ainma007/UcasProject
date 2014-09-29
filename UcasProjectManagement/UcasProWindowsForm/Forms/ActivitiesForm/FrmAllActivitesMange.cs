using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    public partial class FrmAllActivitesMange : Telerik.WinControls.UI.RadForm
    {
        public FrmAllActivitesMange()
        {
            InitializeComponent();
        }

        private void AdActivitesBtn_Click(object sender, EventArgs e)
        {
            FrmAddActivities AddActivfrm = new FrmAddActivities();
            AddActivfrm.ShowDialog();
        }

        private void AddSupActivitesBtn_Click(object sender, EventArgs e)
        {
            
            FrmAddSubActivities AddSub = new FrmAddSubActivities();
            AddSub.ShowDialog();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }
    }
}

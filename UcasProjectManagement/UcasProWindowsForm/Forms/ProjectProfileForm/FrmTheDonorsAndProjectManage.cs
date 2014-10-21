using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.MainForm;

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmTheDonorsAndProjectManage : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           
        }

        private void AddDonorsBtn_Click(object sender, EventArgs e)
        {
            FrmTheDonorsAndProjectAdd frm = new FrmTheDonorsAndProjectAdd();
            frm.ShowDialog();
        }

        private void FrmTheDonorsAndProjectManage_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = TheDonorsProjectCmd.GetAllDonorsBypro(InformationsClass.ProjID);
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;
            if (col == 3)
            {
                FrmTheDonorsAndProjectEdit frm = new FrmTheDonorsAndProjectEdit();
                frm.fillDonorsCombo();
                frm.XDonrPro = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());
                frm.DonorsColumnComboBox.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.CostTextBox.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();

                frm.ShowDialog();
            }
            if (col == 4)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                {
                    TheDonorsProjectCmd.DeleteDonorsProject(int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString()));
                    RadMessageBox.Show(OperationX.DeletedMessage);
                }
            }
        }
    }
}

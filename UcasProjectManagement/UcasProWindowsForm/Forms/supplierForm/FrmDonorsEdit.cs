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

namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmDonorsEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmDonorsEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("telerikMetroBlueTheme");
        }
        public int XDonorsId { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (TheDonorsNameTextBox.Text == "")
            {
                TheDonorsNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;


                TheDonorsNameTextBox.Focus();

                return;
            }
            else
            {
                TheDonorsNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }


            if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {

                TheDonor Donrs = new TheDonor()
                {
                    ID = XDonorsId,
                    Name = TheDonorsNameTextBox.Text,
                    agentName = AgentNameTextBox.Text,
                    Email = EmailTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Fax = faxTextBox4.Text,
                    Adderss = AdressTextBox.Text,



                };
                TheDonorCmd.EditDonor(Donrs);
                RadMessageBox.Show(OperationX.SaveMessagedone);
            }
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void faxTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

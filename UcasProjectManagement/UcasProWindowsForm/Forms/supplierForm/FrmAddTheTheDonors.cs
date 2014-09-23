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
    public partial class FrmAddTheTheDonors : Telerik.WinControls.UI.RadForm
    {
        public FrmAddTheTheDonors()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
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




             TheDonors Donrs=new TheDonors()
            {
                Name= TheDonorsNameTextBox.Text,
                agentName=AgentNameTextBox.Text,
                Email=EmailTextBox.Text,
                PhoneNumber=PhoneNumberTextBox.Text,
                Fax=faxTextBox4.Text,
                Adderss=AdressTextBox.Text,



            };
             TheDonorsCmd.AddDonor(Donrs);
             RadMessageBox.SetThemeName("telerikMetroBlueTheme");

            DialogResult ds = RadMessageBox.Show(this, OperationX.AddMessageDone, "Done", MessageBoxButtons.OK, RadMessageIcon.Info);
        }
        }
    }


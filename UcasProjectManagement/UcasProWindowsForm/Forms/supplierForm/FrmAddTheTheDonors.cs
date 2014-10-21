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
using Ucas.Data.Special_Classes;
namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmAddTheTheDonors : Telerik.WinControls.UI.RadForm
    {
        public FrmAddTheTheDonors()
        {
            InitializeComponent();
            xPeremissions();
            RadMessageBox.SetThemeName("TelerikMetro");
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




             TheDonor Donrs=new TheDonor()
            {
                Name= TheDonorsNameTextBox.Text,
                agentName=AgentNameTextBox.Text,
                Email=EmailTextBox.Text,
                PhoneNumber=PhoneNumberTextBox.Text,
                Fax=faxTextBox4.Text,
                Adderss=AdressTextBox.Text,



            };
             TheDonorCmd.AddDonor(Donrs);
         

             RadMessageBox.Show(this, OperationX.AddMessageDone, "Done", MessageBoxButtons.OK, RadMessageIcon.Info);
        }



        void xPeremissions()
        {
            try
            {
                if (InformationsClass._AddFinncers == 0) { AddBtn.Enabled = false; }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmAddTheTheDonors_Load(object sender, EventArgs e)
        {

        }
        }
    }


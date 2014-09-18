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
    public partial class FrmAddThefinanciers : Telerik.WinControls.UI.RadForm
    {
        public FrmAddThefinanciers()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
             if (ThefinanciersNameTextBox.Text == "")
            {
                ThefinanciersNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

               
                ThefinanciersNameTextBox.Focus();
               
                return;
            }
            else
            {
                ThefinanciersNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }




             Thefinancier finc=new Thefinancier()
            {
                Name= ThefinanciersNameTextBox.Text,
                agentName=AgentNameTextBox.Text,
                Email=EmailTextBox.Text,
                PhoneNumber=PhoneNumberTextBox.Text,
                Fax=faxTextBox4.Text,
                Adderss=AdressTextBox.Text,



            };
           FinanciersCmd.AddFinancier(finc);
            RadMessageBox.SetThemeName("Office2013Light");

            DialogResult ds = RadMessageBox.Show(this, OperationX.AddMessageDone, "Done", MessageBoxButtons.OK, RadMessageIcon.Info);
        }
        }
    }


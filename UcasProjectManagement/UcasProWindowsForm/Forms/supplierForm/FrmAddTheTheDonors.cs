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
           
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (TheDonorsNameTextBox.Text == "")
            {
                TheDonorsNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.TheDonorsNameTextBox, "من فضلك ادخل اسم الممول");


                TheDonorsNameTextBox.Focus();

                return;
            }
            else
            {
                TheDonorsNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion

            Operation.BeginOperation(this);
          

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

             Operation.EndOperation(this);
             Operation.ShowToustOk(OperationX.AddMessageDone, this);

            
             ClearText();
        }



        

        private void FrmAddTheTheDonors_Load(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void faxTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ClearText()
        {
            TheDonorsNameTextBox.Clear();
            AgentNameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
            faxTextBox4.Clear();
            AdressTextBox.Clear();
            TheDonorsNameTextBox.Focus();


        }
        }
    }


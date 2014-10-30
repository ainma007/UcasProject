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
    public partial class FrmEditsupplier : Telerik.WinControls.UI.RadForm
    {
        public FrmEditsupplier()
        {
            InitializeComponent();
        }
        public int XSupID { get; set; }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (NameTextBox.Text == "")
            {
                NameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;


                NameTextBox.Focus();

                return;
            }
            else
            {
                NameTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Supplier Sup = new Supplier()
                {
                    ID = XSupID,
                    Name = NameTextBox.Text,
                    SuppliersNatural = SuppliersNaturalTextBox.Text,
                    Email = EmailTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Fax = faxTextBox4.Text,
                    Adderss = AdressTextBox.Text



                };
                SuppliersCmd.EditSupplier(Sup);
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

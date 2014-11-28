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
        public Ucas.Data.Supplier TragetDSupplier { get; set; }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (NameTextBox.Text == "")
            {
                NameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.NameTextBox, "من فضلك ادخل اسم المورد");

                NameTextBox.Focus();

                return;
            }
            else
            {
                NameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
               

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
                Operation.EndOperation(this);
                RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK,RadMessageIcon.Info);
                this.Close();
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

        private void FrmEditsupplier_Load(object sender, EventArgs e)
        {
            XSupID = TragetDSupplier.ID;
            NameTextBox.Text = TragetDSupplier.Name;
            SuppliersNaturalTextBox.Text = TragetDSupplier.SuppliersNatural;
            EmailTextBox.Text = TragetDSupplier.Email;
            PhoneNumberTextBox.Text = TragetDSupplier.PhoneNumber;
            AdressTextBox.Text = TragetDSupplier.Adderss;
            faxTextBox4.Text = TragetDSupplier.Fax;
        }
    }
}

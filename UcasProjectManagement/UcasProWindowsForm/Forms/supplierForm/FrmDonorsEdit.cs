using System;
using System.Drawing;
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
        public Ucas.Data.TheDonor TragetDoner { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
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
            string mail = EmailTextBox.Text;

            if (EmailTextBox.Text != "")
            {
                if (mail.IndexOf('@') == -1 || mail.IndexOf('.') == -1)
                {
                    errorProvider1.SetError(this.EmailTextBox, "من فضلك بريد صحيح ");
                    return;

                }

            }
            #endregion

            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)

            {
                Operation.BeginOperation(this);
              

                TheDonor tb = new TheDonor()
                {
                    ID = XDonorsId,
                    Name = TheDonorsNameTextBox.Text,
                    agentName = AgentNameTextBox.Text,
                    Email = EmailTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Fax = faxTextBox4.Text,
                    Adderss = AdressTextBox.Text,



                };
                TheDonorCmd.EditDonor(tb);
                Operation.EndOperation(this);
                RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                GC.SuppressFinalize(tb);
                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Dispose();
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

        private void FrmDonorsEdit_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            XDonorsId = TragetDoner.ID;
            TheDonorsNameTextBox.Text = TragetDoner.Name;
            AgentNameTextBox.Text = TragetDoner.agentName;
            EmailTextBox.Text = TragetDoner.Email;
            PhoneNumberTextBox.Text = TragetDoner.PhoneNumber;
            AdressTextBox.Text = TragetDoner.Adderss;
            faxTextBox4.Text = TragetDoner.Fax;

        }

        private void FrmDonorsEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

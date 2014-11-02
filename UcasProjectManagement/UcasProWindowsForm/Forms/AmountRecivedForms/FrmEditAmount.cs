using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    public partial class FrmEditAmount : Telerik.WinControls.UI.RadForm
    {
        public FrmEditAmount()
        {
            InitializeComponent();
        }
        public int XAmountID { get; set; }
        public void FillCombo()
        {
            this.DonorsComboBox.AutoFilter = true;
            this.DonorsComboBox.ValueMember = "ID";
            this.DonorsComboBox.DisplayMember = "Name";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DonorsComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.DonorsComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            DonorsComboBox.DataSource = TheDonorsProjectCmd.GetAllDonorsForAmountsBypro(InformationsClass.ProjID);

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (DonorsComboBox.SelectedValue == null)
            {

                DonorsComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;



                GroupBox.Focus();

                return;
            }
            else
            {
                DonorsComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }

            if (CostTextBox.Text == "")
            {

                CostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                CostTextBox.Focus();

                return;
            }
            else
            {
                CostTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                AmountsReceived tb = new AmountsReceived()
                {
                    ID = XAmountID,
                    TheDonorsProjectID = int.Parse(DonorsComboBox.SelectedValue.ToString()),
                    Date = DateOfProecssPicker.Value.Date,
                    Cost = Convert.ToDouble(CostTextBox.Text),



                };

                AmountsReceivedsCmd.EditAmountsReceived(tb);
                RadMessageBox.Show("Done");
            }
        }
        private void FrmEditAmount_Load(object sender, EventArgs e)
        {

        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && CostTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}

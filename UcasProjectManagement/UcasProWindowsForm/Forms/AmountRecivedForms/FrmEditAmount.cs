using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
        public AmountsReceived TragetAmountsReceived { get; set; }
        private void FillCombo()
        {

            Operation.BeginOperation(this);
          
            this.Invoke((MethodInvoker)delegate
            {
                this.DonorsComboBox.AutoFilter = true;
                this.DonorsComboBox.ValueMember = "ID";
                this.DonorsComboBox.DisplayMember = "TheDonor.Name";
            });


            var q = TheDonorsProjectCmd.GetAllDonorsByproID(InformationsClass.ProjID);
            this.Invoke((MethodInvoker)delegate
            {
                DonorsComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.DonorsComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.DonorsComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "



            if (DonorsComboBox.SelectedValue == null)
            {

                DonorsComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                errorProvider1.SetError(this.DonorsComboBox, "من فضلك ادخل الممول");

                DonorsComboBox.Focus();

                return;
            }
            else
            {
                DonorsComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (CostTextBox.Text == "")
            {

                CostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.CostTextBox, "من فضلك ادخل المبلغ");


                CostTextBox.Focus();

                return;
            }
            else
            {
                CostTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
              

                AmountsReceived tb = new AmountsReceived()
                {
                    ID = XAmountID,
                    TheDonorsProjectID = int.Parse(DonorsComboBox.SelectedValue.ToString()),
                    Date = DateOfProecssPicker.Value.Date,
                    Cost = Convert.ToDouble(CostTextBox.Text),



                };

                AmountsReceivedsCmd.EditAmountsReceived(tb);
                Operation.EndOperation(this);
                RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();
            }
        }
        private void FrmEditAmount_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
             XAmountID = TragetAmountsReceived.ID;
            DonorsComboBox.Text = TragetAmountsReceived.TheDonorsProject.TheDonor.Name;
            DateOfProecssPicker.Text = TragetAmountsReceived.Date.ToString();
            CostTextBox.Text = TragetAmountsReceived.Cost.ToString();
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

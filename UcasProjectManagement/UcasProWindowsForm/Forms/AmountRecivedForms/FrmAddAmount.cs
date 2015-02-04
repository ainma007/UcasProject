using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    public partial class FrmAddAmount : Telerik.WinControls.UI.RadForm
    {
        Thread th;
        public FrmAddAmount()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
       
        private void FillCombo()
        {
          
            Operation.BeginOperation(this);
           
            this.Invoke((MethodInvoker)delegate
            {
                this.DonorsComboBox.MultiColumnComboBoxElement.DropDownWidth = 300;

                this.DonorsComboBox.AutoFilter = true;
                this.DonorsComboBox.ValueMember = "ID";
                this.DonorsComboBox.DisplayMember = "TheDonor.Name";
            });


            var q =TheDonorsProjectCmd.GetAllDonorsByproID(InformationsClass.ProjID);
            this.Invoke((MethodInvoker)delegate
            {
                DonorsComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.DonorsComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.DonorsComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
               



            });
            Operation.EndOperation(this);
            th.Abort();

        }
        private void FrmAddAmount_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            th = new Thread(FillCombo);
            th.Start();

            Coinlabel.Text = InformationsClass.Coin;
            DateOfProecssPicker.Value = DateTime.Now;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
             #region "  CheckFillTextBox "

            if (DonorsComboBox.Text == "")
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
            Operation.BeginOperation(this);
           
            AmountsReceived tb = new AmountsReceived()
            {
                ProjectProfile_ID=InformationsClass.ProjID,
               TheDonorsProjectID=int.Parse(DonorsComboBox.SelectedValue.ToString()),
                Date=DateOfProecssPicker.Value.Date,
                Cost=Convert.ToDouble(CostTextBox.Text),
                


            };

            AmountsReceivedsCmd.NewAmountsReceived(tb);
            Operation.ShowToustOk(OperationX.AddMessageDone, this);
            Operation.EndOperation(this);

            Operation.ShowToustOk(OperationX.AddMessageDone, this);
            GC.SuppressFinalize(tb);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            ClearTextBox();
        }


        private void ClearTextBox()
        {

            DonorsComboBox.ResetText();
            CostTextBox.Clear();
            DonorsComboBox.Focus();


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

        private void CostTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
                          

        }

        private void FrmAddAmount_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
       

      
        }
    }


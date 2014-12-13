using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;
using System.Threading;


namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmTheDonorsAndProjectAdd : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectAdd()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void fillDonorsCombo()
        {

            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.DonorsColumnComboBox.AutoFilter = true;
                this.DonorsColumnComboBox.ValueMember = "ID";
                this.DonorsColumnComboBox.DisplayMember = "Name";
            });
            var q = TheDonorCmd.GetAllDonors();
            this.Invoke((MethodInvoker)delegate
            {
                DonorsColumnComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.DonorsColumnComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.DonorsColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

            });
            Operation.EndOperation(this);

            th.Abort();

            


           
           

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (DonorsColumnComboBox.SelectedValue == null)
            {
                DonorsColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.DonorsColumnComboBox, "من فضلك ادخل اسم الممول");

                DonorsColumnComboBox.Focus();

                return;
            }
            else
            {
                DonorsColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }

            if (CostTextBox.Text == "")
            {

                CostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.CostTextBox, "من فضلك ادخل  الميزانية");

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
           

           
            TheDonorsProject tb = new TheDonorsProject()
            {

                ProjectID = InformationsClass.ProjID,
                DonorsID = int.Parse(DonorsColumnComboBox.SelectedValue.ToString()),
                TotalCost = Convert.ToDouble(CostTextBox.Text)

            };

            TheDonorsProjectCmd.AddTheTheDonorsProject(tb);
            Operation.EndOperation(this);
            RadMessageBox.Show(OperationX.AddMessageDone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
            DonorsColumnComboBox.ResetText();
            CostTextBox.Clear();
            DonorsColumnComboBox.Focus();

           
        }

        private void FrmTheDonorsAndProjectAdd_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            th = new Thread(fillDonorsCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            Operation.EndOperation(this);
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

        private void FrmTheDonorsAndProjectAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

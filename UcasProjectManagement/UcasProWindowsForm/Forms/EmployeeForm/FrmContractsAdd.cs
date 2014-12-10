using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;
using System.Threading;

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmContractsAdd : Telerik.WinControls.UI.RadForm
    {
        public FrmContractsAdd()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
         ///GetAllEmployeeCombo
        private void FillEmployeeCombo()
        {
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "ID";
                this.EmployeeComboBox.DisplayMember = "EmployeeName";
            });
            var q = EmployeeCmd.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                EmployeeComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.EmployeeComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.EmployeeComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

            });
            Operation.EndOperation(this);

          


            
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (EmployeeComboBox.SelectedValue == null)
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.EmployeeComboBox, "من فضلك ادخل اسم الموظف");
                EmployeeComboBox.Focus();

                return;
            }
            else
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (TotaltextBox.Text == "")
            {

                TotaltextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.TotaltextBox, "من فضلك ادخل قيمة العقد");

                TotaltextBox.Focus();

                return;
            }
            else
            {
                TotaltextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (SalaryTextBox.Text == "")
            {

                SalaryTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.SalaryTextBox, "من فضلك ادخل قيمة الراتب");

                SalaryTextBox.Focus();

                return;
            }
            else
            {
                SalaryTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion
            try
            {


                Operation.BeginOperation(this);


                Contract tb = new Contract()
                {
                    Employee_ID = int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                    ProjectProfile_ID = InformationsClass.ProjID,
                    StartDate = DateTime.Parse(StartDateTimePicker.Value.Date.ToShortDateString()),
                    EndDate = DateTime.Parse(EndDateTimePicker.Value.Date.ToShortDateString()),
                    SelaryAmount = Convert.ToDouble(SalaryTextBox.Text),
                    TotalSalary = Convert.ToDouble(TotaltextBox.Text),
                    Status = "فعال",

                };
                ContractCmd.NewContract(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk(OperationX.AddMessageDone, this);

                ClearTxt();
            }
            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(ex.OtherDescription, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

            }
        }
        private void ClearTxt()
        {
            EmployeeComboBox.ResetText();
            SalaryTextBox.Clear();
            EmployeeComboBox.Focus();

        }
        private void FrmContractsAdd_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillEmployeeCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            Coinlabel2.Text = InformationsClass.Coin;
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && SalaryTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

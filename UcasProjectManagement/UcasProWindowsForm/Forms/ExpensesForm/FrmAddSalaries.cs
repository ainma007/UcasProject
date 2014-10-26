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
using Ucas.Data;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmAddSalaries : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSalaries()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void FillCombo()
        {
            ///GetAllContractsProjectID
            this.EmployeeComboBox.AutoFilter = true;
            this.EmployeeComboBox.ValueMember = "ID";
            this.EmployeeComboBox.DisplayMember = "EmployeeName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.EmployeeComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EmployeeComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            EmployeeComboBox.DataSource = ContractCmd.GetAllContractsBypro(InformationsClass.ProjID);

        }
        private void FrmAddSalaries_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            if (EmployeeComboBox.SelectedValue == null)
            {

                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                EmployeeComboBox.Focus();

                return;
            }
            else
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }
            ///
            if (SalaryTextBox.Text == "")
            {

                SalaryTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                SalaryTextBox.Focus();

                return;
            }
            else
            {
                SalaryTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }
            Monthlysalary tb = new Monthlysalary
            {
                ProjectProfile_ID= InformationsClass.ProjID,
                ContractID=int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                Formonth = FromonthDateTimePicker.Value.Date,
                IssueDate = ReleaseDateTimePicker.Value.Date,
                Amount = Convert.ToDouble(SalaryTextBox.Text)

            };
            SalariesCmd.NewSalary(tb);
            RadMessageBox.Show("تمت عملية الاضافة");
            ClearText();
        }


        private void ClearText()
        {
            EmployeeComboBox.ResetText();
            SalaryTextBox.ResetText();
            EmployeeComboBox.Focus();
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
    }
}

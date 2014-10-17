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

            this.EmployeeComboBox.AutoFilter = true;
            this.EmployeeComboBox.ValueMember = "ID";
            this.EmployeeComboBox.DisplayMember = "EmployeeName";
            
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.EmployeeComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EmployeeComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            EmployeeComboBox.DataSource = EmployeeCmd.GetAll();
        }
        private void AddBtn_Click(object sender, EventArgs e)
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
            Contract tb = new Contract()
            {
                Employee_ID=int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                ProjectProfile_ID = InformationsClass.ProjID,
                StartDate=DateTime.Parse( StartDateTimePicker.Value.Date.ToShortDateString()),
                EndDate=DateTime.Parse( EndDateTimePicker.Value.Date.ToShortDateString()),
                SelaryAmount=Convert.ToDouble(SalaryTextBox.Text),
                Status="فعال",

            };
            ContractCmd.NewContract(tb);
            RadMessageBox.Show("تمت الاضافة");
            ClearTxt();
        }
        private void ClearTxt()
        {
            EmployeeComboBox.ResetText();
            SalaryTextBox.Clear();
            EmployeeComboBox.Focus();

        }
        private void FrmContractsAdd_Load(object sender, EventArgs e)
        {
            FillEmployeeCombo();
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

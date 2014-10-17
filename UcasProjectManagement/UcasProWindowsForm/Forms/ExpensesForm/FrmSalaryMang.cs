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

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmSalaryMang : Telerik.WinControls.UI.RadForm
    {
        public FrmSalaryMang()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public int XSalaryID { get; set; }
        public void FillCombo()
        {
            ///GetAllContractsProjectID
            this.ContractComboBox.AutoFilter = true;
            this.ContractComboBox.ValueMember = "ID";
            this.ContractComboBox.DisplayMember = "EmployeeName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.ContractComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.ContractComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            ContractComboBox.DataSource = ContractCmd.GetAllContractsForComboBox(InformationsClass.ProjID);

        }
        private void FrmSalaryMang_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (ContractComboBox.SelectedValue == null)
            {

                ContractComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                ContractComboBox.Focus();

                return;
            }
            else
            {
                ContractComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
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
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Monthlysalary tb = new Monthlysalary()
                {
                    ID = XSalaryID,
                    ContractID = int.Parse(ContractComboBox.SelectedValue.ToString()),
                    Amount = Convert.ToDouble(SalaryTextBox.Text),
                    Formonth = FromonthDateTimePicker.Value.Date,
                    IssueDate = ReleaseDateTimePicker.Value.Date,


                };
                SalariesCmd.EditSalary(tb);
                RadMessageBox.Show("تمت علمية التعديل");
            }
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

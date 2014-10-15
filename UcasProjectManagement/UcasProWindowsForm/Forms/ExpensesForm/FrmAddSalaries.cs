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
            EmployeeComboBox.DataSource = ContractCmd.GetAllContractsForComboBox(InformationsClass.ProjID);

        }
        private void FrmAddSalaries_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
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
        }


        private void ClearText()
        {
            EmployeeComboBox.ResetText();
            SalaryTextBox.ResetText();
            EmployeeComboBox.Focus();
        }
    }
}

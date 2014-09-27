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
        }

        private void FrmContractsAdd_Load(object sender, EventArgs e)
        {
            FillEmployeeCombo();
        }
    }
}

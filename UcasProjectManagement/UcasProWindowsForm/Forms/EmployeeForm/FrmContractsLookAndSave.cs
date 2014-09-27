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
    public partial class FrmContractsLookAndSave : Telerik.WinControls.UI.RadForm
    {
        public FrmContractsLookAndSave()
        {
            InitializeComponent();
        }
        public int myContractId { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Contract tb = new Contract()
            {
                ID=myContractId,
                Employee_ID= int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                StartDate=DateTime.Parse(StartDateTimePicker.Value.Date.ToString()),
                EndDate=DateTime.Parse(EndDateTimePicker.Value.Date.ToString()),
                Status=StatusDropDownList.Text,
                SelaryAmount= Convert.ToDouble(SalaryTextBox.Text)

            };
            ContractCmd.EditContract(tb);
            MessageBox.Show("تمت عملية التعديل");
        }
        public void GetEmplyeeCombo()
        {
            ///GetAllEmployeeCombo
            this.EmployeeComboBox.AutoFilter = true;
            this.EmployeeComboBox.ValueMember = "ID";
            this.EmployeeComboBox.DisplayMember = "EmployeeName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.EmployeeComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EmployeeComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            EmployeeComboBox.DataSource = EmployeeCmd.GetAll();

        }
     
        private void FrmContractsLookAndSave_Load(object sender, EventArgs e)
        {
          //  GetEmplyeeCombo();
          //  GetContractFile();
        }
    }
}

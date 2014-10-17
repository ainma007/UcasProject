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
    }
}

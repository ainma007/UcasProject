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
        public Ucas.Data.Monthlysalary Tragetsalary { get; set; }
        Monthlysalary db = new Monthlysalary();
        public void FillCombo()
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
        private void FrmSalaryMang_Load(object sender, EventArgs e)
        {
            db = new Monthlysalary();
            XSalaryID = Tragetsalary.ID;
            EmployeeComboBox.Text = Tragetsalary.Contract.Employee.EmployeeName;
            SalaryTextBox.Text = Tragetsalary.Amount.ToString();
            FromonthDateTimePicker.Text=Tragetsalary.Formonth.ToString();
            ReleaseDateTimePicker.Text = Tragetsalary.IssueDate.ToString();
            
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (EmployeeComboBox.SelectedValue == null)
            {

                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.EmployeeComboBox, "من فضلك ادخل الموظف");
                EmployeeComboBox.Focus();

                return;
            }
            else
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///
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
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)

            {
                Operation.BeginOperation(this);
                Monthlysalary tb = new Monthlysalary()
                {
                    ID = XSalaryID,
                    ContractID = int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                    Amount = Convert.ToDouble(SalaryTextBox.Text),
                    Formonth = FromonthDateTimePicker.Value.Date,
                    IssueDate = ReleaseDateTimePicker.Value.Date,


                };
                SalariesCmd.EditSalary(tb);
                Operation.EndOperation(this);
                RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();
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

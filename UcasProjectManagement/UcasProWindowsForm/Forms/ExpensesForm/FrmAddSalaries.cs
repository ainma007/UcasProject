using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

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
            ///

            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "ID";
                this.EmployeeComboBox.DisplayMember = "Employee.EmployeeName";
            });
            var q = ContractCmd.GetAllContractsByproID(InformationsClass.ProjID);
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
        private void FrmAddSalaries_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillCombo);
            th.Start();
         
        }

        private void AddBtn1_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);
         

            Monthlysalary tb = new Monthlysalary
            {
                ProjectProfile_ID= InformationsClass.ProjID,
                ContractID=int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                Formonth = FromonthDateTimePicker.Value.Date,
                IssueDate = ReleaseDateTimePicker.Value.Date,
                Amount = Convert.ToDouble(SalaryTextBox.Text)

            };
            SalariesCmd.NewSalary(tb);
            Operation.EndOperation(this);
            RadMessageBox.Show(OperationX.AddMessageDone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
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

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

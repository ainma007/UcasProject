using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmAddSalaries : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSalaries()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void FillCombo()
        {
            ///GetAllContractsProjectID
            ///

            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "ID";
                this.EmployeeComboBox.DisplayMember = "Employee.EmployeeName";
            });
            var q = ContractCmd.GetAllContractsByproID(InformationsClass.ProjID);
            this.Invoke((MethodInvoker)delegate
            {
                EmployeeComboBox.DataSource = q;
               
                this.EmployeeComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor empname = new FilterDescriptor("Employee.EmployeeName", FilterOperator.Contains, "");
                FilterDescriptor empNumber = new FilterDescriptor("Employee.EmployeejobNumber", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(empname);
                compositeFilter.FilterDescriptors.Add(empNumber);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.EmployeeComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

            });
            Operation.EndOperation(this);


            th.Abort();
           
           

            
        }
        private void FrmAddSalaries_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(FillCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            FormonthDateTimePicker.Value = DateTime.Now;
            ReleaseDateTimePicker.Value = DateTime.Now;
           
            
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
            try
            {
                Operation.BeginOperation(this);


                Monthlysalary tb = new Monthlysalary
                {
                    ProjectProfile_ID = InformationsClass.ProjID,
                    ContractID = int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                    Formonth = FormonthDateTimePicker.Value.Date,
                    IssueDate = ReleaseDateTimePicker.Value.Date,
                    Amount = Convert.ToDouble(SalaryTextBox.Text)

                };
                SalariesCmd.NewSalary(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk(OperationX.AddMessageDone, this);
                GC.SuppressFinalize(tb);

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                ClearText();
            }

            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(ex.OtherDescription, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

            }
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

        private void FrmAddSalaries_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);

            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

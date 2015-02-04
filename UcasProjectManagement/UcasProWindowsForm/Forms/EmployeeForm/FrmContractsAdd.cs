using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;
using System.Threading;

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
        Thread th;
        private void FillEmployeeCombo()
        {
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "ID";
                this.EmployeeComboBox.DisplayMember = "EmployeeName";
            });
            var q = EmployeeCmd.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                EmployeeComboBox.DataSource = q;
                this.EmployeeComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor empname = new FilterDescriptor("EmployeeName", FilterOperator.Contains, "");
                FilterDescriptor empNumber = new FilterDescriptor("EmployeejobNumber", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(empname);
                compositeFilter.FilterDescriptors.Add(empNumber);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.EmployeeComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

            });
            Operation.EndOperation(this);


            th.Abort();

            
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (EmployeeComboBox.Text  == "")
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.EmployeeComboBox, "من فضلك ادخل اسم الموظف");
                EmployeeComboBox.Focus();

                return;
            }
            else
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (EmployeeComboBox.SelectedValue == null)
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.EmployeeComboBox, "من فضلك ادخل اسم الموظف");
                EmployeeComboBox.Focus();

                return;
            }
            else
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (TotaltextBox.Text == "")
            {

                TotaltextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.TotaltextBox, "من فضلك ادخل قيمة العقد");

                TotaltextBox.Focus();

                return;
            }
            else
            {
                TotaltextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

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


                Contract tb = new Contract()
                {
                    Employee_ID = int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                    ProjectProfile_ID = InformationsClass.ProjID,
                    StartDate = DateTime.Parse(StartDateTimePicker.Value.Date.ToShortDateString()),
                    EndDate = DateTime.Parse(EndDateTimePicker.Value.Date.ToShortDateString()),
                    SelaryAmount = Convert.ToDouble(SalaryTextBox.Text),
                    TotalSalary = Convert.ToDouble(TotaltextBox.Text),
                    Status = "فعال",

                };
                ContractCmd.NewContract(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk(OperationX.AddMessageDone, this);
                GC.SuppressFinalize(tb);

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();

                ClearTxt();
            }
            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(ex.UserDescriptionArabic, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

            }
        }
        private void ClearTxt()
        {
            EmployeeComboBox.ResetText();
            SalaryTextBox.Clear();
            EmployeeComboBox.Focus();
            TotaltextBox.Clear();

        }
        private void FrmContractsAdd_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

             th = new Thread(FillEmployeeCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            Coinlabel2.Text = InformationsClass.Coin;
            StartDateTimePicker.Value = DateTime.Now;
            EndDateTimePicker.Value = DateTime.Now;
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

        private void FrmContractsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);

            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

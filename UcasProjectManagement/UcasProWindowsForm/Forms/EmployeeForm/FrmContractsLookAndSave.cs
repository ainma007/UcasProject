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
    public partial class FrmContractsLookAndSave : Telerik.WinControls.UI.RadForm
    {
        public Ucas.Data.Contract TragetContract { get; set; }
        public FrmContractsLookAndSave()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        public int myContractId { get; set; }
        Contract db = new Contract();
        private void SaveBtn_Click(object sender, EventArgs e)
        { 
            #region "  CheckFillTextBox "
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
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                
                        {
                            try { 
                            Operation.BeginOperation(this);
                           


                            Contract tb = new Contract()
                            {
                                ID = myContractId,
                                Employee_ID = int.Parse(EmployeeComboBox.SelectedValue.ToString()),
                                StartDate = DateTime.Parse(StartDateTimePicker.Value.Date.ToString()),
                                EndDate = DateTime.Parse(EndDateTimePicker.Value.Date.ToString()),
                                Status = StatusDropDownList.Text,
                                SelaryAmount = Convert.ToDouble(SalaryTextBox.Text),
                                TotalSalary=Convert.ToDouble(TotaltextBox.Text)

                            };
                            ContractCmd.EditContract(tb);
                            Operation.EndOperation(this);

                            RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                            this.Dispose();
                              
                        }
                            catch (Xprema.XpremaException ex)
                            {
                                Operation.EndOperation(this);
                                RadMessageBox.Show(ex.UserDescriptionArabic, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                            }
        }
            
        }

        private void FillEmployeeCombo()
        {
            

            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "ID";
                this.EmployeeComboBox.DisplayMember = "EmployeeName";
            });
            Operation.BeginOperation(this);
            var q = EmployeeCmd.GetAll();
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                EmployeeComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.EmployeeComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.EmployeeComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
                myContractId = TragetContract.ID;
                this.EmployeeComboBox.Text = TragetContract.Employee.EmployeeName;
                this.StartDateTimePicker.Text = TragetContract.StartDate.ToString();
                this.EndDateTimePicker.Text = TragetContract.EndDate.ToString();
                SalaryTextBox.Text = TragetContract.SelaryAmount.ToString();
                this.TotaltextBox.Text = TragetContract.TotalSalary.ToString();
                this.StatusDropDownList.Text = TragetContract.Status.ToString();
            });
            //fillText
            
            

            th.Abort();



        }
        
        private void FrmContractsLookAndSave_Load(object sender, EventArgs e)
        {

            th = new Thread(FillEmployeeCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            Coinlabel2.Text = InformationsClass.Coin;
            
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

        private void FrmContractsLookAndSave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

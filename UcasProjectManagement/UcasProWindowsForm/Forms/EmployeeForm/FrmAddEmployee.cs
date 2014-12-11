using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using Ucas.Data;

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmAddEmployee : Telerik.WinControls.UI.RadForm
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (employeeNameTextBox.Text == "")
            {

                  employeeNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                  errorProvider1.SetError(this.employeeNameTextBox, "من فضلك ادخل اسم الموظف");
                employeeNameTextBox.Focus();
               
                return;
            }
            else
            {
                employeeNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }



            if (GenderDropDownList.Text == "")
            {
               
                  GenderDropDownList.DropDownListElement.TextBox.BackColor = Color.OrangeRed;
                  errorProvider1.SetError(this.GenderDropDownList, "من فضلك ادخل الجنس");
                 
                 GenderDropDownList.Focus();

                return;
            }
            else
            {
                GenderDropDownList.DropDownListElement.TextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (EmployeejobNumberTextBox.Text == "")
            {

                EmployeejobNumberTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.EmployeejobNumberTextBox, "من فضلك ادخل اسم الموظف");
                EmployeejobNumberTextBox.Focus();

                return;
            }
            else
            {
                EmployeejobNumberTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion

            Operation.BeginOperation(this);
            

            Employee emp = new Employee()
            {
                EmployeeName= employeeNameTextBox.Text,
                EmployeeGender=GenderDropDownList.Text.ToString(),
                EmployeejobNumber=EmployeejobNumberTextBox.Text,
                EmployeeNationalNumber=EmployeeNationalNumberTextBox4.Text,
                Email=EmailTextBox.Text,
                PhoneNumber=PhoneNumberTextBox.Text,
                Mobilenumber=MobilenumberTextBox.Text,



            };
            EmployeeCmd.addEmployee(emp);
            Operation.EndOperation(this);
            Operation.ShowToustOk(OperationX.AddMessageDone, this);

            ClearTxt();
        }

        private void ClearTxt()
        {
            employeeNameTextBox.Clear();
            GenderDropDownList.ResetText();
           EmployeejobNumberTextBox.Clear();
            EmployeeNationalNumberTextBox4.Clear();
             EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
             MobilenumberTextBox.Clear();
             employeeNameTextBox.Focus();
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
           
            //=========================
        }
      
        private void EmployeejobNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MobilenumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EmployeeNationalNumberTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

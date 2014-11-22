using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmEmployeeEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmEmployeeEdit()
        {
            InitializeComponent();
        }

        public int XIDEmployee { get; set; }
        public Ucas.Data.Employee TragetEmployee { get; set; }
        private void FrmEmployeeEdit_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            XIDEmployee = TragetEmployee.ID;
            employeeNameTextBox.Text = TragetEmployee.EmployeeName;
            EmployeejobNumberTextBox.Text = TragetEmployee.EmployeejobNumber;
            GenderDropDownList.Text = TragetEmployee.EmployeeGender;
            EmailTextBox.Text = TragetEmployee.Email;
            PhoneNumberTextBox.Text = TragetEmployee.PhoneNumber;
            MobilenumberTextBox.Text = TragetEmployee.Mobilenumber;
            EmployeeNationalNumberTextBox4.Text = TragetEmployee.EmployeeNationalNumber;
            this.Cursor = Cursors.Default;

        }



        private void SaveBtn_Click(object sender, EventArgs e)
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
            #endregion
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "SaveMessage", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                Employee db = new Employee()
                {
                    ID = XIDEmployee,
                    EmployeeName = employeeNameTextBox.Text,
                    EmployeeGender = GenderDropDownList.Text.ToString(),
                    EmployeejobNumber = EmployeejobNumberTextBox.Text,
                    EmployeeNationalNumber = EmployeeNationalNumberTextBox4.Text,
                    Email = EmailTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Mobilenumber = MobilenumberTextBox.Text,

                };
                EmployeeCmd.EditEmployee(db);
                this.Cursor = Cursors.Default;
                RadMessageBox.Show("تمت عملية الحفظ");

            }
        }
    }
}
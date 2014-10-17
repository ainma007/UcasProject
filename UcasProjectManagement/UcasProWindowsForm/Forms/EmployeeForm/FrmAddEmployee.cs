using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using Ucas.Data;
using Ucas.Data.Special_Classes;

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
            if (employeeNameTextBox.Text == "")
            {

                  employeeNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
               
                employeeNameTextBox.Focus();
               
                return;
            }
            else
            {
                employeeNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }



            if (GenderDropDownList.SelectedItem == null)
            {
                //GenderDropDownList.BackColor = System.Drawing.Color.Red;
                  GenderDropDownList.DropDownListElement.TextBox.BackColor = Color.OrangeRed;
               // GenderDropDownList.DropDownListElement.TextBox.Fill.BackColor = Color.OrangeRed;


                GenderDropDownList.Focus();

                return;
            }
            else
            {
                GenderDropDownList.DropDownListElement.TextBox.BackColor = Color.White;
            }

            Employee emp = new Employee()
            {
                EmployeeName= employeeNameTextBox.Text,
                EmployeeGender=GenderDropDownList.SelectedItem.ToString(),
                EmployeejobNumber=EmployeejobNumberTextBox.Text,
                EmployeeNationalNumber=EmployeeNationalNumberTextBox4.Text,
                Email=EmailTextBox.Text,
                PhoneNumber=PhoneNumberTextBox.Text,
                Mobilenumber=MobilenumberTextBox.Text,



            };
            EmployeeCmd.addEmployee(emp);


            RadMessageBox.Show("تمت الاضافة");
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
            Xperemissions();
            //=========================
        }
        #region "   Activate Peremissions     "
        void Xperemissions()
        {
            try
            {
                if (InformationsClass._AddEmployee == 0) { AddBtn.Enabled = false; }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion 

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

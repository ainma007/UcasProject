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

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmEditUserNameAndPassword : Telerik.WinControls.UI.RadForm
    {
        public FrmEditUserNameAndPassword()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
       
        private void FrmEditUserNameAndPassword_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (OldPasswordTextBox.Text == "")
            {

                OldPasswordTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.OldPasswordTextBox, "من فضلك ادخل كلمة المرور القديمة");
                OldPasswordTextBox.Focus();

                return;
            }
            else
            {
                OldPasswordTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }


            ///         

            if (NewuserNameTextBox.Text == "")
            {

                NewuserNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.NewuserNameTextBox, "من فضلك ادخل اسم المستخدم الجديد");
                NewuserNameTextBox.Focus();

                return;
            }
            else
            {
                NewuserNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (NewpasswordTextBox.Text == "")
            {

                NewpasswordTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.NewpasswordTextBox, "من فضلك ادخل اسم كلمة المرور الجديدة");
                NewuserNameTextBox.Focus();

                return;
            }
            else
            {
                NewpasswordTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion
            if (OldPasswordTextBox.Text != InformationsClass.xCurrentUserPass)
            {

                RadMessageBox.Show("كلمة المرور القديمة خاطئة", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                OldPasswordTextBox.Focus();

                return;

            }
             if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
             {
                 try { 
            UserTb tb = new UserTb
            {
                ID=InformationsClass.xCurrentUserID,
                UserName=NewuserNameTextBox.Text,
                Password=NewpasswordTextBox.Text,
                TypeUser=InformationsClass.XUserType,

            };

            UsersCmd.EditUser(tb);
            RadMessageBox.Show("سيتم اعادة تشغيل البرنامج ", "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);


            Application.Restart();
                 }
                 catch (Xprema.XpremaException ex)
                 {
                     Operation.EndOperation(this);
                     RadMessageBox.Show(ex.UserDescriptionArabic, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                 }

        }
        }
    }
}

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
namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmLogin : Telerik.WinControls.UI.RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        UcasProEntities cmd = new UcasProEntities();
        private void EnterBtn_Click(object sender, EventArgs e)
        {

            #region "  CheckFillTextBox "
            if (UserNameTextBox.Text == "")
            {

                UserNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.UserNameTextBox, "من فضلك ادخل كلمة المرور");
                UserNameTextBox.Focus();

                return;
            }
            else
            {
                UserNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (PasswordTextBox.Text == "")
            {

                PasswordTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.PasswordTextBox, "من فضلك ادخل كلمة المرور");
                PasswordTextBox.Focus();

                return;
            }
            else
            {
                PasswordTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion

            Operation.BeginOperation(this);
            var q = UsersCmd.Login(UserNameTextBox.Text.ToString(), PasswordTextBox.Text.ToString());
            cmd = new UcasProEntities();
           
         
            if (q != null)
            {
                InformationsClass.xCurrentUserID = q.ID;
                InformationsClass.xCurrentUserName = q.UserName;
                InformationsClass.xCurrentUserPass = q.Password;
                InformationsClass.XUserType = q.TypeUser;
                //==============================================
                if (InformationsClass.XUserType == "غير فعال")
                {
                    RadMessageBox.Show("غير مصرح لك بالدخول");
                    Operation.EndOperation(this);
                    Application.Exit();

                }
                else
                {
                     FrmAdmin frm = new FrmAdmin();
                    frm.Show();
                }
               

                Operation.EndOperation(this);
                this.Hide();

            }
            else
            {
                Operation.EndOperation(this);
                RadMessageBox.Show("خطأ في اسم المستخدم وكلمة المرور ","",MessageBoxButtons.OK,RadMessageIcon.Error);//Load msg from Opertation Class
            }

            
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                EnterBtn_Click(sender, e);
                e.Handled = true;


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.ShowDialog();
        }
    }
}

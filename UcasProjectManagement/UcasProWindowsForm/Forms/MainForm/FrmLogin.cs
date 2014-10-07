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
using Ucas.Data.Special_Classes;
namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmLogin : Telerik.WinControls.UI.RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        void clearTXT()
        {
            UserNameTextBox.Clear();
            PsswordTextBox.Clear();

            UserNameTextBox.Focus();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            clearTXT();

        }




        int xGroupID;
        void TransfaireGroupDataInf()
        {
            var ListOfAllPeremissions = InformationsClass.GetAllGroupPeremissionsByGroupID(xGroupID);
            foreach (var item in ListOfAllPeremissions)
            {
                InformationsClass._AddUser = Convert.ToInt32(item.AddUser);
                InformationsClass._UpDateUser = Convert.ToInt32(item.UpDateUser);
                InformationsClass._DeleteUser = Convert.ToInt32(item.DeleteUser);
                InformationsClass._AddEmployee = Convert.ToInt32(item.AddEmployee);
                InformationsClass._EditEmployee = Convert.ToInt32(item.EditEmployee);
                InformationsClass._DeleteEmployee = Convert.ToInt32(item.DeleteEmployee);
                InformationsClass._AddProject = Convert.ToInt32(item.AddProject);
                InformationsClass._AddFinncers = Convert.ToInt32(item.AddFinncers);
                InformationsClass._EditFinncers = Convert.ToInt32(item.EditFinncers);
                InformationsClass._DeleteFinncers = Convert.ToInt32(item.DeleteFinncers);
                InformationsClass._AddSuppliers = Convert.ToInt32(item.AddSuppliers);
                InformationsClass._DeleteSuppliers = Convert.ToInt32(item.EditSuppliers);
                InformationsClass._DeleteSuppliers = Convert.ToInt32(item.DeleteSuppliers);
                InformationsClass._DisplayExpenses = Convert.ToInt32(item.DisplayExpenses);
                InformationsClass._CanPrint = Convert.ToInt32(item.CanPrint);

            }
        }
        int xUserID;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                xUserID = UsersCmd.GetCurrentUserIDByNameAndPass(UserNameTextBox.Text, PsswordTextBox.Text);
                var GetCurrentUserFullData = UsersCmd.GetLoginUserDataByID(xUserID);
                foreach (var item in GetCurrentUserFullData)
                {
                    xGroupID = Convert.ToInt32(item.GroupID);
                    InformationsClass.xCurrentUserID = item.ID;
                    InformationsClass.xCurrentUserName = UserNameTextBox.Text;
                    InformationsClass.xCurrentUserPass = PsswordTextBox.Text;
                    InformationsClass._GroupID = Convert.ToInt32(item.GroupID);
                }
                TransfaireGroupDataInf();
                //=====================================================================
                int ChkActiveUser = ProjectControlCmd.ChkProjectIDByUserID(xUserID);


                if (ChkActiveUser != 0)
                {
                    string GetUserStausValue = ProjectControlCmd.GetStatusByID(xUserID);
                    switch (GetUserStausValue)
                    {
                        case "فعال":

                            FrmMainUserPro frpro = new FrmMainUserPro();
                            frpro.Show();
                            break;


                    }

                    switch (GetUserStausValue)
                    {
                        case "غير فعال":
                         MessageBox.Show(" تم ايقاف الحساب"); clearTXT(); return;
                         break;
 
                    }

                }

                else
                {
                    FrmAdmin fr = new FrmAdmin();
                     fr.Show();

                }
                
            }
            catch (Exception)
            {

                MessageBox.Show(" تأكد من اسم المستخدم وكلمة المرور"); clearTXT(); return;
            }
        }







        private void TryBtn_Click(object sender, EventArgs e)
        {
            clearTXT();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

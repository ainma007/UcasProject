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
            var ListOfAllPeremissions = PeremissionsHolderClass.GetAllGroupPeremissionsByGroupID(xGroupID);
            foreach (var item in ListOfAllPeremissions)
            {
                PeremissionsHolderClass._AddUser = Convert.ToInt32(item.AddUser);
                PeremissionsHolderClass._UpDateUser = Convert.ToInt32(item.UpDateUser);
                PeremissionsHolderClass._DeleteUser = Convert.ToInt32(item.DeleteUser);
                PeremissionsHolderClass._AddEmployee = Convert.ToInt32(item.AddEmployee);
                PeremissionsHolderClass._EditEmployee = Convert.ToInt32(item.EditEmployee);
                PeremissionsHolderClass._DeleteEmployee = Convert.ToInt32(item.DeleteEmployee);
                PeremissionsHolderClass._AddProject = Convert.ToInt32(item.AddProject);
                PeremissionsHolderClass._AddFinncers = Convert.ToInt32(item.AddFinncers);
                PeremissionsHolderClass._EditFinncers = Convert.ToInt32(item.EditFinncers);
                PeremissionsHolderClass._DeleteFinncers = Convert.ToInt32(item.DeleteFinncers);
                PeremissionsHolderClass._AddSuppliers = Convert.ToInt32(item.AddSuppliers);
                PeremissionsHolderClass._DeleteSuppliers = Convert.ToInt32(item.EditSuppliers);
                PeremissionsHolderClass._DeleteSuppliers = Convert.ToInt32(item.DeleteSuppliers);
                PeremissionsHolderClass._DisplayExpenses = Convert.ToInt32(item.DisplayExpenses);
                PeremissionsHolderClass._CanPrint = Convert.ToInt32(item.CanPrint);

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
                    PeremissionsHolderClass.xCurrentUserID = item.ID;
                    PeremissionsHolderClass.xCurrentUserName = UserNameTextBox.Text;
                    PeremissionsHolderClass.xCurrentUserPass = PsswordTextBox.Text;
                    PeremissionsHolderClass._GroupID = Convert.ToInt32(item.GroupID);
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

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
        void clearTXT() {
            UserNameTextBox.Clear();
            PsswordTextBox.Clear();

            UserNameTextBox.Focus();
        }
        
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            clearTXT();

        }

        Int32 xGroupID;
        void TransfaireGroupDataInf() {
            var ListOfAllPeremissions = PeremissionsHolderClass.GetAllGroupPeremissionsByGroupID(xGroupID);
            foreach (var item in ListOfAllPeremissions )
            {
                PeremissionsHolderClass._AddUser = Convert.ToInt32(item.AddUser);
                PeremissionsHolderClass._UpDateUser = Convert.ToInt32( item.UpDateUser);
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
        Int32  xUserID = 0;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
           

                var GetUsre = UsersCmd.GetCurrentUserByNameAndPass(UserNameTextBox.Text, PsswordTextBox.Text);
                
                //=================================================================================================

               foreach (var item in GetUsre)
                {
                   
                    //if (item.ID == 0)
                    //{
                    //    MessageBox.Show("Error data");
                    //    clearTXT();
                    //    return;
                    //}
                   
                        xUserID = item .ID ;
                        //===============================================================
                        // Transfare Peremissions :
                        PeremissionsHolderClass.xCurrentUserID = item.ID;
                        PeremissionsHolderClass.xCurrentUserName = UserNameTextBox.Text;
                        PeremissionsHolderClass.xCurrentUserPass = PsswordTextBox.Text;
                        PeremissionsHolderClass._GroupID = Convert.ToInt32(item.GroupID);

                        xGroupID = Convert.ToInt32(item.GroupID);
                        TransfaireGroupDataInf();
                        MessageBox.Show("Found ");

                    
                    int ChkActiveUser = ProjectControlCmd.ChkProjectIDByUserID(xUserID);
                    if (ChkActiveUser != 0)
                    {
                        string GetUserStausValue = ProjectControlCmd.GetStatusByID(item.ID);
                        if (GetUserStausValue == "فعال")
                        {
                            MessageBox.Show("فعال");

                            FrmMainUserPro frpro = new FrmMainUserPro();
                            frpro.Show();


                        }
                        else
                        {
                            MessageBox.Show("غير فعال");


                        } 
                    }

                    else
                    {

                        FrmAdmin fr = new FrmAdmin();
                        fr.Show();

                    }
                   
                           
                } // for each
          
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

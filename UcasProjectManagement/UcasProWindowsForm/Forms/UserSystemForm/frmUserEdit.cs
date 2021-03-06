﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using Ucas.Data;
using Telerik.WinControls.UI;
using System.Linq;
using System.Data.Linq;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class frmUserEdit : Telerik.WinControls.UI.RadForm
    {
        public frmUserEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public Ucas.Data.UserTb TragetUser { get; set; }
       
        public int XUserId  { get; set; }
      
        private void frmUserEdit_Load(object sender, EventArgs e)
        
       {
           this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
           // this.Cursor = Cursors.WaitCursor;
           // TragetUser = new UserTb();

          ReFrishData();

        }
        UserPermession px = new UserPermession();
        private void ReFrishData()
        {
           
            px = new UserPermession();
            XUserId = TragetUser.ID ;
            this.employeeNameTextBox.Text = TragetUser.Employee.EmployeeName;
            this.UserNameTextBox.Text = TragetUser.UserName;
            this.PasswordTextBox.Text = TragetUser.Password;
            this.TypeDropDownList.Text = TragetUser.TypeUser;
            var q = TragetUser.UserPermessions;

          

          //  var xData = UsersCmd.GetAllSystemPermession();
          //  foreach (var item in xData )
          //  {

          //      dataGridView1.Rows.Add( new string []{item.ID.ToString (), item.PermessionName, item.Desription});                
          //  }
          ////  ==========================================================
          //  var lst = UsersCmd.GetAllUserPermissonsByUserID(XUserId);
          //  int rw = 0;
          //  foreach (var i in lst)
          //  {
                
          //      if (i.PermessionValue.ToString () == "True"){
          //          dataGridView1.Rows[rw].Cells[3].Value = "True";
          //      }
          //      rw++;
          //  }

        }
    
        private void btnOky_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (UserNameTextBox.Text == "")
            {

                UserNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.UserNameTextBox, "من فضلك ادخل اسم المستخدم");
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
                if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                    Operation.BeginOperation(this);


                    UserTb tb = new UserTb
                    {
                        ID = XUserId,
                        UserName = UserNameTextBox.Text,
                        Password = PasswordTextBox.Text,
                        TypeUser = TypeDropDownList.Text

                    };
                    UsersCmd.EditUser(tb);
                    Operation.EndOperation(this);
                    RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                    GC.SuppressFinalize(tb);
                    GC.Collect();
                    GC.WaitForFullGCComplete();
                    GC.WaitForPendingFinalizers();
                    this.Dispose();

                }
                catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(ex.UserDescriptionArabic, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

            }
               
            
            //string xValue = "";


            //==========================================
            //UsersCmd.ClearAllUserPermessions(XUserId);
            //===========================================
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{

            //    DataGridViewCheckBoxCell chkchecking = dataGridView1.Rows[i].Cells[3] as DataGridViewCheckBoxCell;
            //    if (Convert.ToBoolean(chkchecking.Value) == true)
            //    { xValue = "True"; }
            //    else { xValue = "False"; }

            //    px.PermessioID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //    px.PermessionValue = xValue;
            //    px.UserID = XUserId;
            //    PeremissionsSystemCmd.AddPeremission(px);
            //}


            //MessageBox.Show(" Changes Was Saved ..");
            //frmUserEdit_Load(sender, e);
          
           
              
        }

        }
                       
        private void frmUserEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }




    }
}

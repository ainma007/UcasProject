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
        }
        public Ucas.Data.UserTb TragetUser { get; set; }
       
        public int XUserId  { get; set; }
      
        private void frmUserEdit_Load(object sender, EventArgs e)
        
       {
           // this.Cursor = Cursors.WaitCursor;
           // TragetUser = new UserTb();

           ReFrishData();

        }
        UserPermession px = new UserPermession();
        private void ReFrishData()
        {
           
            px = new UserPermession();
            this.employeeNameTextBox.Text = TragetUser.Employee.EmployeeName;
            this.UserNameTextBox.Text = TragetUser.UserName;
            this.PasswordTextBox.Text = TragetUser.Password;
            var q = TragetUser.UserPermessions;
            radGridView1.Rows.Clear();
            var xData = UsersCmd.GetAllSystemPermession();
            foreach (var item in xData )
            {

                var UserPerm = q.Where(p => p.ID == item.ID).SingleOrDefault();
                if (UserPerm == null)
                {

                    radGridView1.Rows.Add(item.ID, item.PermessionName, false, 0);
                }
                else
                {
                 
                  radGridView1.Rows.Add(item.ID, item.PermessionName, bool.Parse(UserPerm.PermessionValue.ToString()), UserPerm.ID);
                }

            }

        }
    
        private void btnOky_Click(object sender, EventArgs e)
        {
            

            foreach (var item in radGridView1.Rows)
            {
                var q = UsersCmd.GetAllSystemPermession().Where(p => p.ID == int.Parse(item.Cells[0].Value.ToString())).SingleOrDefault();
                UserPermession px = new UserPermession();
               
                if (int.Parse(item.Cells[3].Value.ToString())==0)
                {
                    px.PermessioID = q.ID;
                    px.PermessionValue = item.Cells[2].Value.ToString();
                    px.UserID = TragetUser.ID;
                    UsersCmd.SaveUserPermession(px);

                }
                else
                {
                    px.ID = int.Parse(item.Cells[3].Value.ToString());
                    px.PermessioID = q.ID;
                    px.PermessionValue = item.Cells[2].Value.ToString();
                    px.UserID = TragetUser.ID;
                
                    UsersCmd.EditPermessionValue(px);
                  
                  

                }
            }
        }

        private void frmUserEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Dispose();
        }
    }
}

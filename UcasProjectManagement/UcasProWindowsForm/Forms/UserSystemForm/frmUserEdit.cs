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
            //this.employeeNameTextBox.Text = TragetUser.Employee.EmployeeName;
            //this.radTextBox1.Text = TragetUser.UserName;
            //this.radTextBox2.Text=
           
            PermesssionGdv.DataSource = UsersCmd.GetAllSystemPermession();
            radGridView1.DataSource = PeremissionsSystemCmd.GetAllUserPeremissionsByID(XUserId);
         

        }
        UserPermession tb = new UserPermession();
        private void btnOky_Click(object sender, EventArgs e)
        {
           string  xvalue = "";
            if (XUserId != 0)
            {
                tb = new UserPermession ();
                for (int i = 0; i < radGridView1 .Rows .Count - 1 ; i++)
                {
                    xvalue  =  radGridView1 .Rows [i].Cells [3].Value .ToString ();
                    tb.UserID = XUserId;
                if (xvalue == "True") { tb.PermessionValue = "True"; } else { tb.PermessionValue = "False"; }
                PeremissionsSystemCmd.EditPeremission(tb);
                }

                
            }

        }
    }
}

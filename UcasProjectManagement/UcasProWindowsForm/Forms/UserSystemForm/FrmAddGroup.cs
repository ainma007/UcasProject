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
using System.Collections;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmAddGroup : Telerik.WinControls.UI.RadForm
    {
        public FrmAddGroup()
        {
            InitializeComponent();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        #region "  PopulateCheckList       "
        private void PopulateCheckList() {
            PermssionList.Items.Clear();
            PermssionList.Items.Add("أضافة مستخدم جديد");
            PermssionList.Items.Add("تعديل مستخدم ");
            PermssionList.Items.Add("حذف مستخدم");
            PermssionList.Items.Add("أضافة مشروع جديد");
            PermssionList.Items.Add("الأطلاع على مصروفات المشروع");
            PermssionList.Items.Add("أمكانية طباعه التقارير ");
            PermssionList.Items.Add("أضافة عامل جديد");
            PermssionList.Items.Add("أضافة مورد جديد");
            PermssionList.Items.Add("أضافة ممول جديد");
            PermssionList.Items.Add("تعديل بيانات عامل");
            PermssionList.Items.Add("حذف بيانات عامل");
            PermssionList.Items.Add("تعديل بيانات ممول");
            PermssionList.Items.Add("حذف بيانات ممول");
            PermssionList.Items.Add("تعديل بيانات مورد");
            PermssionList.Items.Add("حذف بيانات مورد");
        

      }
        #endregion 

        #region " CheckList Status  "
        void CheckedAll() {
            for (int i = 0; i < PermssionList .Items .Count ; i++)
            {
                PermssionList.SetItemCheckState(i, CheckState.Checked);

            }
        }
        void UnCheckedAll() {
            for (int i = 0; i < PermssionList.Items.Count; i++)
            {
                PermssionList.SetItemCheckState(i, CheckState.Unchecked );

            }
        }
        
        #endregion 
          

        private void FrmAddGroup_Load(object sender, EventArgs e)
        {
            PopulateCheckList();

        }
        GroupsTb gtb = new GroupsTb();
        PeremissionsTb ptb = new PeremissionsTb();
        private void AddBtn_Click(object sender, EventArgs e)
        {
           
                if (GroupNameTextBox.Text != null)
                {
                    gtb = new GroupsTb();
                    gtb.GroupName = GroupNameTextBox.Text;
                    gtb .Description =   DescreptionTextBox.Text;
                    GroupCmd.AddGroup(gtb);
                    //==============================================
                    int xLastGroupID = GroupCmd.GetLastGroupID();                
                   //==============================================
                    ptb = new PeremissionsTb();
                    ArrayList Lst = new ArrayList() ;
                   
                    for (int per = 0; per < PermssionList .Items .Count ; per++)
                    {                   
                        string r = PermssionList.GetItemCheckState(PermssionList.Items.IndexOf(per)).ToString();
                        if (r.ToString() == "Checked")
                        { Lst.Add (1); }
                        else
                        {  Lst.Add(0); }                    
                    }
                    
                    ptb.GroupID = xLastGroupID;
                    ptb.AddUser = int.Parse (Lst[0].ToString ());
                    ptb.UpDateUser  = int.Parse(Lst[1].ToString());
                    ptb.DeleteUser  = int.Parse(Lst[2].ToString());
                    ptb.AddProject  = int.Parse(Lst[3].ToString());
                    ptb.DisplayExpenses  = int.Parse(Lst[4].ToString());
                    ptb.CanPrint = int.Parse(Lst[5].ToString());
                    ptb.AddEmployee  = int.Parse(Lst[6].ToString());
                    ptb.AddSuppliers  = int.Parse(Lst[7].ToString());
                    ptb.AddFinncers  = int.Parse(Lst[8].ToString());
                    ptb.EditEmployee  = int.Parse(Lst[9].ToString());
                    ptb.DeleteEmployee  = int.Parse(Lst[10].ToString());
                    ptb.EditFinncers  = int.Parse(Lst[11].ToString());
                    ptb.DeleteFinncers  = int.Parse(Lst[12].ToString());
                    ptb.EditSuppliers = int.Parse(Lst[13].ToString());
                    ptb.DeleteSuppliers  = int.Parse(Lst[14].ToString());

                    PeremissionsCmd.AddPeremissions(ptb);
                    MessageBox.Show("Saved ..");
              
            }
           
        }

        private void TheChecker_CheckedChanged(object sender, EventArgs e)
        {
            if (TheChecker.CheckState == CheckState.Checked) { CheckedAll(); } else { UnCheckedAll(); }
        }
    }
}

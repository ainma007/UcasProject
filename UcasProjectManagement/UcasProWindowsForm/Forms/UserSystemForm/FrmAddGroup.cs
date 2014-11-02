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
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        #region "  PopulateCheckList       "
        private void PopulateCheckList()
        {
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
        void CheckedAll()
        {
            for (int i = 0; i < PermssionList.Items.Count; i++)
            {
                PermssionList.SetItemCheckState(i, CheckState.Checked);

            }
        }
        void UnCheckedAll()
        {
            for (int i = 0; i < PermssionList.Items.Count; i++)
            {
                PermssionList.SetItemCheckState(i, CheckState.Unchecked);

            }
        }

        #endregion


        private void FrmAddGroup_Load(object sender, EventArgs e)
        {
            PopulateCheckList();

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (GroupNameTextBox.Text != null)
            {
                GroupsTb gtb = new GroupsTb()
                {
                    GroupName = GroupNameTextBox.Text.ToString(),
                    Description = DescreptionTextBox.Text.ToString(),

                };
                GroupCmd.AddGroup(gtb);
                //==============================================

                int xlast = GroupCmd.GetLastGroupID();
                MessageBox.Show("" + xlast.ToString());
                // ==============================================

                ArrayList Lst = new ArrayList();

                foreach (string i in PermssionList.Items)
                {

                    string r = PermssionList.GetItemCheckState(PermssionList.Items.IndexOf(i)).ToString();
                    if (r.ToString() == "Checked")
                    { Lst.Add(1); }
                    else { Lst.Add(0); }


                }

                PeremissionsTb ptb = new PeremissionsTb()
                {
                    GroupID = xlast,
                   
                    UpDateUser = int.Parse(Lst[1].ToString()),
                 
                    AddProject = int.Parse(Lst[3].ToString()),
                    DisplayExpenses = int.Parse(Lst[4].ToString()),
                    CanPrint = int.Parse(Lst[5].ToString()),
                    AddEmployee = int.Parse(Lst[6].ToString()),
                    AddSuppliers = int.Parse(Lst[7].ToString()),
                    AddFinncers = int.Parse(Lst[8].ToString()),
                    EditEmployee = int.Parse(Lst[9].ToString()),
                    DeleteEmployee = int.Parse(Lst[10].ToString()),
                    EditFinncers = int.Parse(Lst[11].ToString()),
                    DeleteFinncers = int.Parse(Lst[12].ToString()),
                    EditSuppliers = int.Parse(Lst[13].ToString()),
                    DeleteSuppliers = int.Parse(Lst[14].ToString()),
                };


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

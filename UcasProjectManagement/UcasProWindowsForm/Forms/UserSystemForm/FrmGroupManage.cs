﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmGroupManage : Telerik.WinControls.UI.RadForm
    {
        public FrmGroupManage()
        {
            InitializeComponent();
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
        public int xGroupId { get; set; }
        private void FrmGroupManage_Load(object sender, EventArgs e)
        {
            groupsTbBindingSource.DataSource = GroupCmd.GetAllGroups();

            PopulateCheckList();
        }

        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {

            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.xGroupId = int.Parse((currentRow.Cells[0].Value.ToString()));
                this.GroupNameTextBox.Text = (currentRow.Cells[1].Value.ToString());
                this.DescreptionTextBox.Text = (currentRow.Cells[2].Value.ToString());





            }

        }
        private void GetcURRENTgRPpERM() {

            if (xGroupId != 0)
            {
                var lstperm = PeremissionsCmd.GetAllPeremissions(xGroupId);
                foreach (var item in lstperm )
                {
                    
                }
                foreach (string  item in PermssionList .Items )
                {
                    
                }

            }        
        }
        private void GroupGridView_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanelInfo(this.GroupGridView.CurrentRow, 5);


        }
    }
}

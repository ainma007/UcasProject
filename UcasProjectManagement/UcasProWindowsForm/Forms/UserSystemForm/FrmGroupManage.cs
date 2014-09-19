using System;
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

                GetCurrentPeremissions();



            }

        }
        private void GetCurrentPeremissions() {
            try
            {
                
            if (xGroupId != 0)
            {
                var lstperm =  PeremissionsCmd.GetAllPeremissions(xGroupId );

                foreach(var  item in lstperm )
                {
                    if (item.AddUser.Value == 1) { PermssionList.SetItemCheckState(0, CheckState.Checked); } else { PermssionList.SetItemCheckState(0, CheckState.Unchecked ); }

                    if (item.UpDateUser.Value == 1) { PermssionList.SetItemCheckState(1, CheckState.Checked); } else { PermssionList.SetItemCheckState(1, CheckState.Unchecked); }

                    if (item.DeleteUser.Value == 1) { PermssionList.SetItemCheckState(2, CheckState.Checked); } else { PermssionList.SetItemCheckState(2, CheckState.Unchecked); }

                    if (item.AddUser.Value == 1) { PermssionList.SetItemCheckState(3, CheckState.Checked); } else { PermssionList.SetItemCheckState(3, CheckState.Unchecked); }

                    if (item.AddProject.Value == 1) { PermssionList.SetItemCheckState(4, CheckState.Checked); } else { PermssionList.SetItemCheckState(4, CheckState.Unchecked); }

                    if (item.DisplayExpenses.Value == 1) { PermssionList.SetItemCheckState(5, CheckState.Checked); } else { PermssionList.SetItemCheckState(5, CheckState.Unchecked); }

                    if (item.CanPrint.Value == 1) { PermssionList.SetItemCheckState(6, CheckState.Checked); } else { PermssionList.SetItemCheckState(6, CheckState.Unchecked); }

                    if (item.AddEmployee.Value == 1) { PermssionList.SetItemCheckState(7, CheckState.Checked); } else { PermssionList.SetItemCheckState(7, CheckState.Unchecked); }

                    if (item.AddSuppliers.Value == 1) { PermssionList.SetItemCheckState(8, CheckState.Checked); } else { PermssionList.SetItemCheckState(8, CheckState.Unchecked); }

                    if (item.AddFinncers.Value == 1) { PermssionList.SetItemCheckState(9, CheckState.Checked); } else { PermssionList.SetItemCheckState(9, CheckState.Unchecked); }

                    if (item.EditEmployee.Value == 1) { PermssionList.SetItemCheckState(10, CheckState.Checked); } else { PermssionList.SetItemCheckState(10, CheckState.Unchecked); }

                    if (item.DeleteEmployee.Value == 1) { PermssionList.SetItemCheckState(11, CheckState.Checked); } else { PermssionList.SetItemCheckState(11, CheckState.Unchecked); }

                    if (item.EditFinncers.Value == 1) { PermssionList.SetItemCheckState(12, CheckState.Checked); } else { PermssionList.SetItemCheckState(12, CheckState.Unchecked); }

                    if (item.DeleteFinncers.Value == 1) { PermssionList.SetItemCheckState(13, CheckState.Checked); } else { PermssionList.SetItemCheckState(13, CheckState.Unchecked); }

                    if (item.EditSuppliers.Value == 1) { PermssionList.SetItemCheckState(14, CheckState.Checked); } else { PermssionList.SetItemCheckState(12, CheckState.Unchecked); }


                }
               

            }        
            }
            catch (Exception)
            {
                
             
            }
        }
        private void GroupGridView_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanelInfo(this.GroupGridView.CurrentRow, 5);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmContratsManage : Telerik.WinControls.UI.RadForm
    {
        public FrmContratsManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public int GetContractsID { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmContractsAdd Addfrm = new FrmContractsAdd();
            Addfrm.ShowDialog();
            this.Cursor = Cursors.Default;

        }
        private void FillData()
        {

            ContractsGridView.DataSource = ContractCmd.GetAllContractsByproID(InformationsClass.ProjID);

        }
        private void FrmContratsManage_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = ContractsGridView.CurrentColumn.Index;

            if (col == 8)
            {
                this.Cursor = Cursors.WaitCursor;
                FrmContractsLookAndSave frm = new FrmContractsLookAndSave();

                Ucas.Data.Contract db = (Ucas.Data.Contract)ContractsGridView.CurrentRow.DataBoundItem;
                frm.TragetContract = db;
                frm.GetEmplyeeCombo();
                //frmsave.myContractId = int.Parse(radGridView1.CurrentRow.Cells["ID"].Value.ToString());
                //frmsave.EmployeeComboBox.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
                //frmsave.StartDateTimePicker.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
                //frmsave.EndDateTimePicker.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
                //frmsave.SalaryTextBox.Text = radGridView1.CurrentRow.Cells[4].Value.ToString();
                //frmsave.StatusDropDownList.Text = radGridView1.CurrentRow.Cells[5].Value.ToString();
                                               
                frm.ShowDialog();
                this.Cursor = Cursors.Default; 
                return;
            }

            if (col == 9)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {

                    ContractCmd.DeleteContract(int.Parse(ContractsGridView.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show(OperationX.DeletedMessage);
                    return;
                }
               
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void FrmContratsManage_Activated(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmContratsManage_Load(sender, e);
            this.Cursor = Cursors.Default; 
        }
    }
}

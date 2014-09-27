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
        }
        public int GetContractsID { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmContractsAdd Addfrm = new FrmContractsAdd();
            Addfrm.ShowDialog();

        }
        private void FillData()
        {

            radGridView1.DataSource = ContractCmd.GetAllContractsBypro(InformationsClass.ProjID);

        }
        private void FrmContratsManage_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            FrmContractsLookAndSave frmsave = new FrmContractsLookAndSave();
            frmsave.GetEmplyeeCombo();
            frmsave.myContractId = int.Parse(radGridView1.CurrentRow.Cells["ID"].Value.ToString());
            frmsave.EmployeeComboBox.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsave.StartDateTimePicker.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsave.EndDateTimePicker.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsave.SalaryTextBox.Text = radGridView1.CurrentRow.Cells[4].Value.ToString();
            frmsave.StatusDropDownList.Text = radGridView1.CurrentRow.Cells[5].Value.ToString();


           
          //  frmsave.myContractId = GetContractsID;
            frmsave.ShowDialog();

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}

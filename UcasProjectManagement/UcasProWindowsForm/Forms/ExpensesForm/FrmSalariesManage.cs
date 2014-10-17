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

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmSalariesManage : Telerik.WinControls.UI.RadForm
    {
        public FrmSalariesManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddSalaries Addfrm = new FrmAddSalaries();
            Addfrm.ShowDialog();
        }

        private void FrmSalariesManage_Load(object sender, EventArgs e)
        {
            monthlysalaryBindingSource.DataSource = SalariesCmd.GetAllSalaryBypro(InformationsClass.ProjID);
        }

        private void SalaryGridView_CommandCellClick(object sender, EventArgs e)
        {
             var col = SalaryGridView.CurrentColumn.Index;

             if (col == 5)
             {
                 FrmSalaryMang EditSalary= new FrmSalaryMang();
                 EditSalary.FillCombo();
                 EditSalary.XSalaryID = int.Parse(SalaryGridView.CurrentRow.Cells[0].Value.ToString());
                 EditSalary.ContractComboBox.Text = SalaryGridView.CurrentRow.Cells[1].Value.ToString();
                 EditSalary.SalaryTextBox.Text = SalaryGridView.CurrentRow.Cells[2].Value.ToString();
                 EditSalary.FromonthDateTimePicker.Text = SalaryGridView.CurrentRow.Cells[3].Value.ToString();
                 EditSalary.ReleaseDateTimePicker.Text = SalaryGridView.CurrentRow.Cells[4].Value.ToString();
                 

                 EditSalary.ShowDialog();
                 return;

             }

             if (col == 6)
             {

                 if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                 {

                     SalariesCmd.DeleteSalary(int.Parse(SalaryGridView.CurrentRow.Cells[0].Value.ToString()));
                     RadMessageBox.Show("تمت علمية الحذف");
                     return;
                 }

             }
        }
    }
}

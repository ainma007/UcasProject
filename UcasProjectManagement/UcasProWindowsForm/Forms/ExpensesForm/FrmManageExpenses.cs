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
    public partial class FrmManageExpenses : Telerik.WinControls.UI.RadForm
    {
        public FrmManageExpenses()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void FrmManageExpenses_Load(object sender, EventArgs e)
        {

            projectExpensBindingSource.DataSource = ProjectExpensesCmd.ExpensesByProjectID(InformationsClass.ProjID);

        }

        private void ExpensesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ExpensesGridView.CurrentColumn.Index;

            if (col == 8)
            {
              
                FrmEditExpense EditExpense = new FrmEditExpense();
                EditExpense.FillComboBox();
                EditExpense.XExpID = int.Parse(ExpensesGridView.CurrentRow.Cells[0].Value.ToString());
                EditExpense.ExpensesNameTextBox.Text = ExpensesGridView.CurrentRow.Cells[1].Value.ToString();
                EditExpense.DateOfProecssPicker.Text = ExpensesGridView.CurrentRow.Cells[2].Value.ToString();
                EditExpense.BillTextBox.Text = ExpensesGridView.CurrentRow.Cells[3].Value.ToString();
                EditExpense.RequiarAmountTextBox.Text = ExpensesGridView.CurrentRow.Cells[4].Value.ToString();
                EditExpense.CashingNumberTextBox.Text = ExpensesGridView.CurrentRow.Cells[5].Value.ToString();
                EditExpense.SupplierComboBox.Text = ExpensesGridView.CurrentRow.Cells[6].Value.ToString();
                EditExpense.SubActivtiesComboBox.Text = ExpensesGridView.CurrentRow.Cells[7].Value.ToString();

                EditExpense.ShowDialog();
                return;

            }



            if (col == 9)
            {
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                       // ProjectExpens tb = projectExpensBindingSource.Current as ProjectExpens;
                        ProjectExpensesCmd.DeleteProjectExpens(int.Parse(ExpensesGridView.CurrentRow.Cells[0].Value.ToString()));
                        RadMessageBox.Show("تمت علمية الحذف");
                        return;
                    }
                }
            }
        }
    }
}
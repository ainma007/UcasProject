using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
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
        private void TotalExpenses()
        {

            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("RequiarAmount", "المجموع الكلي = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.ExpensesGridView.SummaryRowsBottom.Add(summaryRowItem);
        }
        private void FrmManageExpenses_Load(object sender, EventArgs e)
        {
            ExpensesGridView.MasterView.TableHeaderRow.MaxHeight = 50;
          ExpensesGridView.DataSource  = ProjectExpensesCmd.ExpensesByProjectID(InformationsClass.ProjID);

          for (int i = 1; i <= ExpensesGridView .Rows .Count ; i++)
          {
              ExpensesGridView.Rows[i-1].Cells["Num"].Value = i.ToString();
          }

          TotalExpenses();
         
        }

        private void ExpensesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ExpensesGridView.CurrentColumn.Index;

            if (col == 9)
            {
              
                FrmEditExpense EditExpense = new FrmEditExpense();
                EditExpense.FillComboBox();
                EditExpense.XExpID = int.Parse(ExpensesGridView.CurrentRow.Cells[1].Value.ToString());
                EditExpense.ExpensesNameTextBox.Text = ExpensesGridView.CurrentRow.Cells[2].Value.ToString();
                EditExpense.DateOfProecssPicker.Text = ExpensesGridView.CurrentRow.Cells[3].Value.ToString();
                EditExpense.BillTextBox.Text = ExpensesGridView.CurrentRow.Cells[4].Value.ToString();
                EditExpense.RequiarAmountTextBox.Text = ExpensesGridView.CurrentRow.Cells[5].Value.ToString();
                EditExpense.CashingNumberTextBox.Text = ExpensesGridView.CurrentRow.Cells[6].Value.ToString();
                EditExpense.SupplierComboBox.Text = ExpensesGridView.CurrentRow.Cells[7].Value.ToString();
                EditExpense.SubActivtiesComboBox.Text = ExpensesGridView.CurrentRow.Cells[8].Value.ToString();

                EditExpense.ShowDialog();
                return;

            }



            if (col == 10)
            {
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                       // ProjectExpens tb = projectExpensBindingSource.Current as ProjectExpens;
                        ProjectExpensesCmd.DeleteProjectExpens(int.Parse(ExpensesGridView.CurrentRow.Cells[1].Value.ToString()));
                        RadMessageBox.Show("تمت علمية الحذف");
                        return;
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddExpenses frm = new FrmAddExpenses();
            frm.ShowDialog();
        }
    }
}
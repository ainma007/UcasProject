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
            this.ExpensesGridView.SummaryRowsBottom.Clear();
            this.ExpensesGridView.SummaryRowsBottom.Add(summaryRowItem);
        }
        private void FrmManageExpenses_Load(object sender, EventArgs e)
        {


            FillExpensesData();
            TotalExpenses();
        }

        private void FillExpensesData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";

            });
            Operation.BeginOperation(this);
            try
            {
                Application.DoEvents();
                ExpensesGridView.DataSource = ProjectExpensesCmd.GetAllExpensesByProject(InformationsClass.ProjID);

                for (int i = 1; i <= ExpensesGridView.Rows.Count; i++)
                {
                    ExpensesGridView.Rows[i - 1].Cells["Num"].Value = i.ToString();
                }

               


                Application.DoEvents();
            }

            catch (System.InvalidOperationException ex)
            {

                Application.DoEvents();
                ExpensesGridView.DataSource = ProjectExpensesCmd.GetAllExpensesByProject(InformationsClass.ProjID);

                for (int i = 1; i <= ExpensesGridView.Rows.Count; i++)
                {
                    ExpensesGridView.Rows[i - 1].Cells["Num"].Value = i.ToString();
                }

                
                Application.DoEvents();
            }

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = " ";

            });
            

        }
      

        private void ExpensesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ExpensesGridView.CurrentColumn.Index;

            if (col == 9)
            {
              
                
                
                this.Cursor = Cursors.WaitCursor;
                FrmEditExpense frm = new FrmEditExpense();
                Ucas.Data.ProjectExpens Expenses = (Ucas.Data.ProjectExpens)ExpensesGridView.CurrentRow.DataBoundItem;
                frm.TragetExpens = Expenses;
                frm.FillComboBox();
                frm.ShowDialog();
                this.Cursor = Cursors.Default;         
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
            this.Cursor = Cursors.WaitCursor;
            FrmAddExpenses frm = new FrmAddExpenses();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void RefrechBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmManageExpenses_Load(sender, e);
            this.Cursor = Cursors.Default;
        }

        private void FrmManageExpenses_Activated(object sender, EventArgs e)
        {
          //  FrmManageExpenses_Load(sender, e);
        }
    }
}
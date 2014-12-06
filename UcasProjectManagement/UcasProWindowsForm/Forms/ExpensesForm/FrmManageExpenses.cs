using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("RequiarAmount", "الاجمالي={0}" + InformationsClass.Coin + " ", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.ExpensesGridView.SummaryRowsBottom.Clear();
            this.ExpensesGridView.SummaryRowsBottom.Add(summaryRowItem);
        }
        private void FrmManageExpenses_Load(object sender, EventArgs e)
        {

            Thread th = new Thread(FillExpensesData);
            th.Start();
           // FillExpensesData();
            TotalExpenses();
        }

        private void FillExpensesData()
        {

            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = ProjectExpensesCmd.GetAllExpensesByProject(InformationsClass.ProjID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                ExpensesGridView.DataSource = q;
                for (int i = 1; i <= ExpensesGridView.Rows.Count; i++)
                {
                    ExpensesGridView.Rows[i - 1].Cells["Num"].Value = i.ToString();
                }
                StatusLabel1.Text = "";

            });
            

        }
      

        private void ExpensesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ExpensesGridView.CurrentColumn.Index;

            if (col == 9)
            {



                Operation.BeginOperation(this);
                FrmEditExpense frm = new FrmEditExpense();
                Ucas.Data.ProjectExpens Expenses = (Ucas.Data.ProjectExpens)ExpensesGridView.CurrentRow.DataBoundItem;
                frm.TragetExpens = Expenses;
              
                frm.ShowDialog();
                Operation.EndOperation(this);      
                return;

            }



            if (col == 10)
            {
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {

                        if (ProjectExpensesCmd.DeleteProjectExpens(int.Parse(ExpensesGridView.CurrentRow.Cells[1].Value.ToString())))
                        {
                            Operation.BeginOperation(this);
                            Operation.ShowToustOk(OperationX.DeletedMessage, this);
                            FrmManageExpenses_Load(sender, e);
                            Operation.EndOperation(this);
                            return;
                        }
                        else
                        {
                            Operation.EndOperation(this);
                            RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                        }
                        
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddExpenses frm = new FrmAddExpenses();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void RefrechBtn_Click(object sender, EventArgs e)
        {
          
            FrmManageExpenses_Load(sender, e);
           
        }

        private void FrmManageExpenses_Activated(object sender, EventArgs e)
        {
          //  FrmManageExpenses_Load(sender, e);
        }
    }
}
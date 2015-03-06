using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using System.Drawing;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmManageExpenses : Telerik.WinControls.UI.RadForm
    {
        public FrmManageExpenses()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void TotalExpenses()
        {
            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("RequiarAmount", "الاجمالي={0}" + InformationsClass.Coin + " ", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.ExpensesGridView.SummaryRowsBottom.Clear();
            this.ExpensesGridView.SummaryRowsBottom.Add(summaryRowItem);
        }
        private void FrmManageExpenses_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(FillExpensesData);
            th.Start();
           
           
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

          
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                ExpensesGridView.DataSource = q;
                for (int i = 1; i <= ExpensesGridView.Rows.Count; i++)
                {
                    ExpensesGridView.Rows[i - 1].Cells["Num"].Value = i.ToString();
                }
                StatusLabel1.Text = "";
                TotalExpenses();
            });
            Operation.EndOperation(this);
            th.Abort();
        }
      

        private void ExpensesGridView_CommandCellClick(object sender, EventArgs e)
        {
            if (InformationsClass.Accountant == 0)
            {
                RadMessageBox.Show("غير مصرحة لك الصلاحية", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;

            }
            var col = ExpensesGridView.CurrentColumn.Index;

            if (col == 9)
            {



                Operation.BeginOperation(this);
                FrmEditExpense frm = new FrmEditExpense();
                Ucas.Data.ProjectExpens Expenses = (Ucas.Data.ProjectExpens)ExpensesGridView.CurrentRow.DataBoundItem;
                frm.TragetExpens = Expenses;
              
                frm.ShowDialog();
                Operation.EndOperation(this);
                FrmManageExpenses_Load(null, null);
            }



            if (col == 10)
            {
                {
                    if (RadMessageBox.Show(this, OperationX.DeleteMessage, "حذف", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        
                        if (ProjectExpensesCmd.DeleteProjectExpens(((Ucas.Data.ProjectExpens)this.ExpensesGridView.CurrentRow.DataBoundItem).ID))
                        {
                            Operation.ShowToustOk(OperationX.DeletedMessage, this);
                            FrmManageExpenses_Load(null, null);
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
            if (InformationsClass.Accountant == 0)
            {
                RadMessageBox.Show("غير مصرحة لك الصلاحية", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;

            }
            Operation.BeginOperation(this);
            FrmAddExpenses frm = new FrmAddExpenses();
            frm.ShowDialog();
            Operation.EndOperation(this);
            FrmManageExpenses_Load(null, null);
        }

        private void RefrechBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FrmManageExpenses_Load(null, null);
            this.Cursor = Cursors.Default;
           
        }

      

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            List<ExpensessReportObj> ls = new List<ExpensessReportObj>();
            int counter = 0;
            foreach (GridViewRowInfo item in ExpensesGridView.ChildRows)
            {
                counter++;
                ls.Add(new ExpensessReportObj()
                {
                   // ExpensessID = counter,
                    coin = item.Cells["Coin"].Value.ToString(),
                    ProjectName = item.Cells["ProjectName"].Value.ToString(),
                    ExpensessName = item.Cells["ExpensesName"].Value.ToString(),
                    DateOfs = DateTime.Parse(item.Cells["DateofProcess"].Value.ToString()),
                    Bill_SerialNumber = item.Cells["BillNumber"].Value.ToString(),
                    ExpenssesCost= double.Parse(item.Cells["RequiarAmount"].Value.ToString()),
                    CashingNumber = item.Cells["CashingNumber"].Value.ToString(),
                    SupplierName = item.Cells["SupplierName"].Value.ToString(),
                    SubActivityName = item.Cells["ProjectSubActivity"].Value.ToString(),
                });
            }
            Reports.ReportCommand.ExpensessReportCmd cmd = new Reports.ReportCommand.ExpensessReportCmd();
            cmd.ShowReportByGrid(ls);
            Operation.EndOperation(this);
        }

        private void FrmManageExpenses_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}
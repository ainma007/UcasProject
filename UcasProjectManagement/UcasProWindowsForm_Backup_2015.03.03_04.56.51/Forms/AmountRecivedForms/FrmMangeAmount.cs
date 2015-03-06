using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;
using System.Drawing;

namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    public partial class FrmMangeAmount : Telerik.WinControls.UI.RadForm
    {
        public FrmMangeAmount()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void TotalAmount()
        {
            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("Cost", "الاجمالي={0}" + InformationsClass.Coin + " ", GridAggregateFunction.Sum);
            
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.radGridView1.SummaryRowsBottom.Clear();
            this.radGridView1.SummaryRowsBottom.Add(summaryRowItem);
            ///

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (InformationsClass.Accountant == 0)
            {
                RadMessageBox.Show("غير مصرحة لك الصلاحية", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;

            }
            Operation.BeginOperation(this);
          

            FrmAddAmount Frm = new FrmAddAmount();
            Frm.ShowDialog();
            Operation.EndOperation(this);
            this.FrmMangeAmount_Load(null, null);
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            if (InformationsClass.Accountant == 0)
            {
                RadMessageBox.Show("غير مصرحة لك الصلاحية", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;

            }
            var col = radGridView1.CurrentColumn.Index;

            if (col == 5)
            {
                Operation.BeginOperation(this);
                FrmEditAmount EditAmount = new FrmEditAmount();
                Ucas.Data.AmountsReceived db = (Ucas.Data.AmountsReceived)radGridView1.CurrentRow.DataBoundItem;
                EditAmount.TragetAmountsReceived = db;
                EditAmount.ShowDialog();
                Operation.EndOperation(this);
                this.FrmMangeAmount_Load(null, null);

            }
            if (col == 6)
            {

                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "حذف السجل", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);


                    if (AmountsReceivedsCmd.DeleteAmountsReceived(((Ucas.Data.AmountsReceived)this.radGridView1.CurrentRow.DataBoundItem).ID))
                    Operation.ShowToustOk(OperationX.DeletedMessage, this);
                    Operation.EndOperation(this);
                    this.FrmMangeAmount_Load(null, null);

                }
                else
                {
                    Operation.EndOperation(this);
                    RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        private void FrmMangeAmount_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(LodingAmount);
            th.Start();
           
           
        }

        private void LodingAmount()
        {

            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = AmountsReceivedsCmd.GetAllAmountsReceivedBypro(InformationsClass.ProjID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                radGridView1.DataSource = q;
                TotalAmount();
                StatusLabel1.Text = "";

            });
            th.Abort();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.FrmMangeAmount_Load(null, null);
            this.Cursor = Cursors.Default;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            List<AmountRecvtReportObj> ls = new List<AmountRecvtReportObj>();
          
            //    ls.Add(new SalaryReportObj() {  SalarysID = counter});
            foreach (GridViewRowInfo item in radGridView1.ChildRows)
            {
               
                ls.Add(new AmountRecvtReportObj()
                {

                    DonerName = item.Cells["DonorName"].Value.ToString(),
                    Date =DateTime.Parse (item.Cells["Date"].Value.ToString()),
                    Cost =double.Parse(item.Cells["Cost"].Value.ToString()),
                    ProjectName = item.Cells["ProjectName"].Value.ToString(),
                    Coin = item.Cells["Coin"].Value.ToString(),
                  
                });
            }
            Reports.ReportCommand.AmountRecvReportCmd cmd = new Reports.ReportCommand.AmountRecvReportCmd();
            cmd.ShowReportByGrid(ls);
            Operation.EndOperation(this);
        }

        private void FrmMangeAmount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        } 
       
    }
}

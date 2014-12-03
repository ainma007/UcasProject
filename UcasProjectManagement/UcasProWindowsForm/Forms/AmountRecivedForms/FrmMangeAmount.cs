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

namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    public partial class FrmMangeAmount : Telerik.WinControls.UI.RadForm
    {
        public FrmMangeAmount()
        {
            InitializeComponent();
        }
        private void TotalAmount()
        {

            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("Cost", "المجموع الكلي   = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.radGridView1.SummaryRowsBottom.Clear();
            this.radGridView1.SummaryRowsBottom.Add(summaryRowItem);
            ///

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddAmount Frm = new FrmAddAmount();
            Frm.ShowDialog();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;

            if (col == 5)
            {
                Operation.BeginOperation(this);
                FrmEditAmount EditAmount = new FrmEditAmount();
                Ucas.Data.AmountsReceived db = (Ucas.Data.AmountsReceived)radGridView1.CurrentRow.DataBoundItem;
                EditAmount.TragetAmountsReceived = db;
                EditAmount.ShowDialog();
                Operation.EndOperation(this);
                return;

            }
            if (col == 6)
            {

                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "حذف السجل", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                   

                    AmountsReceivedsCmd.DeleteAmountsReceived(int.Parse(radGridView1.CurrentRow.Cells[1].Value.ToString()));
                    radGridView1.DataSource = AmountsReceivedsCmd.GetAllAmountsReceivedBypro(InformationsClass.ProjID);
                    Operation.ShowToustOk(OperationX.DeletedMessage, this);
                    Operation.EndOperation(this);
                    FrmMangeAmount_Load(sender, e);
                    return;

                }
                else
                {
                    RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        private void FrmMangeAmount_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(LodingAmount);
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
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmMangeAmount_Load(sender, e);
        }
    }
}

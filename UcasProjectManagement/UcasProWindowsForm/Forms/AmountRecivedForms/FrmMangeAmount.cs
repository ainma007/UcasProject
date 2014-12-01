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
                FrmEditAmount EditAmount = new FrmEditAmount();
                EditAmount.FillCombo();
                EditAmount.XAmountID = int.Parse(radGridView1.CurrentRow.Cells[1].Value.ToString());
                EditAmount.DonorsComboBox.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
                EditAmount.DateOfProecssPicker.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
                EditAmount.CostTextBox.Text = radGridView1.CurrentRow.Cells[4].Value.ToString();



                EditAmount.ShowDialog();
                return;

            }
            if (col == 6)
            {

                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    AmountsReceivedsCmd.DeleteAmountsReceived(int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString()));
                    radGridView1.DataSource = AmountsReceivedsCmd.GetAllAmountsReceivedBypro(InformationsClass.ProjID);
                    return;

                }
            }
        }

        private void FrmMangeAmount_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(LodingAmount);
            th.Start();
            //LodingAmount();
           
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
                StatusLabel1.Text = "";

            });
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmMangeAmount_Load(sender, e);
        }
    }
}

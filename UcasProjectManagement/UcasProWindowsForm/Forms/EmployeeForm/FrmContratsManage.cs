﻿using System;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.EmployeeForm
{
    public partial class FrmContratsManage : Telerik.WinControls.UI.RadForm
    {
        public FrmContratsManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public int GetContractsID { get; set; }
       
       
     
        private void FrmContratsManage_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillData);
            th.Start();

        }
        private void TotalAmount()
        {
            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("TotalSalary", "الاجمالي={0}" + InformationsClass.Coin + " ", GridAggregateFunction.Sum);

            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.ContractsGridView.SummaryRowsBottom.Clear();
            this.ContractsGridView.SummaryRowsBottom.Add(summaryRowItem);
            ///

        }
        private void FillData()
        {
            Operation.BeginOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";
            });

           
            Application.DoEvents();
            var q = ContractCmd.GetAllContractsByproID(InformationsClass.ProjID);
            Application.DoEvents();

           
           
           
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                ContractsGridView.DataSource = q;
                TotalAmount();
                toolStripStatusLabel1.Text = "";
            });

            Operation.EndOperation(this);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
           

            FrmContractsAdd Addfrm = new FrmContractsAdd();
            Addfrm.ShowDialog();
            Operation.EndOperation(this);

        }
        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = ContractsGridView.CurrentColumn.Index;

            if (col == 8)
            {
                Operation.BeginOperation(this);
               

                FrmContractsLookAndSave frm = new FrmContractsLookAndSave();

                Ucas.Data.Contract db = (Ucas.Data.Contract)ContractsGridView.CurrentRow.DataBoundItem;
                frm.TragetContract = db;
            
               
                                               
                frm.ShowDialog();
                Operation.EndOperation(this);
                return;
            }

            if (col == 9)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    if (ContractCmd.DeleteContract(int.Parse(ContractsGridView.CurrentRow.Cells[0].Value.ToString())))
                    {
                        Operation.ShowToustOk(OperationX.DeletedMessage, this);

                        Operation.EndOperation(this);
                        FrmContratsManage_Load(sender, e);
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
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmContratsManage_Load(sender, e);
        }

        private void FrmContratsManage_Activated(object sender, EventArgs e)
        {
           // this.Cursor = Cursors.WaitCursor;
           //// FrmContratsManage_Load(sender, e);
           // this.Cursor = Cursors.Default; 
        }
    }
}

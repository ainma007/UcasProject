using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportCommand;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmManagementTheDonors : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementTheDonors()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void GetAllFinanciers()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = TheDonorCmd.GetAllDonors();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                DonersGridView.DataSource = q;
                StatusLabel1.Text = "";

            });
            th.Abort();
           
        }



        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
           
            th = new Thread(GetAllFinanciers);
            th.Start();
           

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            

            FrmAddTheTheDonors frm = new FrmAddTheTheDonors();
            frm.ShowDialog();
            Operation.EndOperation(this);
            FrmManagementFinanciers_Load(null, null);
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            List<DonaorReportObj> ls = new List<DonaorReportObj>();
            int counter = 0;
          
            foreach (GridViewRowInfo item in DonersGridView.ChildRows)
            {
                counter++;
                ls.Add(new DonaorReportObj()
                {
                    DonorID = counter,
                    DonorName = item.Cells["Name"].Value.ToString(),
                    DonorAddress = item.Cells["Adderss"].Value.ToString(),
                    DonorAgentname = item.Cells["agentName"].Value.ToString(),
                    DonorFaxnumber = item.Cells["Fax"].Value.ToString(),
                    DonorEmail = item.Cells["Email"].Value.ToString(),
                    DonorPhoneNumber = item.Cells["PhoneNumber"].Value.ToString(),


                });
            }
            Reports.ReportCommand.DonorsReportCmd cmd = new Reports.ReportCommand.DonorsReportCmd();
            cmd.ShowEmpReportByGrid(ls);
            Operation.EndOperation(this);
           

        }

        private void DonersGridView_CommandCellClick(object sender, EventArgs e)
        {

            var col = DonersGridView.CurrentColumn.Index;
            if (col == 7)
            {
                Operation.BeginOperation(this);
                FrmDonorsEdit frm = new FrmDonorsEdit();
                Ucas.Data.TheDonor db = (Ucas.Data.TheDonor)DonersGridView.CurrentRow.DataBoundItem;
                frm.TragetDoner = db;
                frm.ShowDialog();
                Operation.EndOperation(this);

                FrmManagementFinanciers_Load(null, null);

            }

            if (col == 8)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Operation.BeginOperation(this);
                      

                        if (TheDonorCmd.DeleteDonor(int.Parse(DonersGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                            
                            FrmManagementFinanciers_Load(null, null);
                            Operation.ShowToustOk(OperationX.DeletedMessage, this);
                            Operation.BeginOperation(this);
                        


                        }
                        else
                        {
                            Operation.BeginOperation(this);
                            RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                        }

                        Operation.EndOperation(this);
                    }
                    catch (Exception)
                    {
                        
                        return;
                    }
                   
                }

            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FrmManagementFinanciers_Load(null, null);
            this.Cursor = Cursors.Default;

        }

        private void FrmManagementTheDonors_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }


    }
}
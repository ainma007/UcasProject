using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportCommand;

namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmManagementTheDonors : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementTheDonors()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

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
           
        }



        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(GetAllFinanciers);
            th.Start();
          //  GetAllFinanciers();

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            

            FrmAddTheTheDonors frm = new FrmAddTheTheDonors();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            DonorsReportCmd cmd = new DonorsReportCmd();
            cmd.GetAllDonor();
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
                           
                            Operation.ShowToustOk(OperationX.DeletedMessage, this);
                            Operation.BeginOperation(this);
                            FrmManagementFinanciers_Load(sender, e);


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
            FrmManagementFinanciers_Load(sender, e);
        }


    }
}
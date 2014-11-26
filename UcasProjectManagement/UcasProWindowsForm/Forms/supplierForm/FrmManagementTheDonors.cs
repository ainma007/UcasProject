using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            theDonorsBindingSource.DataSource = TheDonorCmd.GetAllDonors();
        }



        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
            GetAllFinanciers();

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmAddTheTheDonors frm = new FrmAddTheTheDonors();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DonorsReportCmd cmd = new DonorsReportCmd();
            cmd.GetAllDonor();
            this.Cursor = Cursors.Default;

        }

        private void DonersGridView_CommandCellClick(object sender, EventArgs e)
        {

            var col = DonersGridView.CurrentColumn.Index;
            if (col == 7)
            {
                this.Cursor = Cursors.WaitCursor;
                FrmDonorsEdit frm = new FrmDonorsEdit();
                Ucas.Data.TheDonor db = (Ucas.Data.TheDonor)DonersGridView.CurrentRow.DataBoundItem;
                frm.TragetDoner = db;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;


            }

            if (col == 8)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        TheDonorCmd.DeleteDonor(int.Parse(DonersGridView.CurrentRow.Cells[0].Value.ToString()));
                        RadMessageBox.Show(OperationX.DeletedMessage);
                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception)
                    {
                        
                        return;
                    }
                   
                }

            }

        }


    }
}
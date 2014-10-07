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

            theDonorsBindingSource.DataSource = TheDonorsCmd.GetAllDonors();
        }
        private void LockGrid()
        {
            for (int i = 0; i <= DonersGridView.Rows.Count - 1; i++)
            {
                DonersGridView.Rows[i].Cells[0].ReadOnly = true;
                DonersGridView.Rows[i].Cells[1].ReadOnly = true;
                DonersGridView.Rows[i].Cells[2].ReadOnly = true;
                DonersGridView.Rows[i].Cells[3].ReadOnly = true;
                DonersGridView.Rows[i].Cells[4].ReadOnly = true;
                DonersGridView.Rows[i].Cells[5].ReadOnly = true;
                DonersGridView.Rows[i].Cells[6].ReadOnly = true;
                DonersGridView.Rows[i].Cells[7].ReadOnly = true;
                DonersGridView.Rows[i].Cells[8].ReadOnly = true;




            }

        }
        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
            GetAllFinanciers();
            LockGrid();
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DonersGridView.Rows[e.RowIndex].Cells[0].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[2].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[3].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[4].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[5].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[6].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[7].ReadOnly = false;
            DonersGridView.Rows[e.RowIndex].Cells[8].ReadOnly = false;
        }

        private void FinanciersGridView_CommandCellClick(object sender, EventArgs e)
        {
            try{  
        var col = DonersGridView.CurrentColumn.Index;
        if (col == 8)
        {
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                TheDonors Donrs = theDonorsBindingSource.Current as TheDonors;
                TheDonorsCmd.EditDonor(Donrs);
               GetAllFinanciers();
                LockGrid();
            }
            else
            {

                 GetAllFinanciers();
                LockGrid();
            }
        }
        if (col == 9) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                        TheDonors Donrs = theDonorsBindingSource.Current as TheDonors;
                        TheDonorsCmd.DeleteDonor(Donrs.ID);
                       GetAllFinanciers();
                       LockGrid();
                    }

            }
            }
           
         catch (Exception)
            {

                return;
            }
        }

        }


    }

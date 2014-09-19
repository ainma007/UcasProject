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
    public partial class FrmManagementFinanciers : Telerik.WinControls.UI.RadForm
    {
        public FrmManagementFinanciers()
        {
            InitializeComponent();
        }

        private void GetAllFinanciers()
        {

            thefinancierBindingSource.DataSource = FinanciersCmd.GetAllFinanciers();
        }
        private void LockGrid()
        {
            for (int i = 0; i <= FinanciersGridView.Rows.Count - 1; i++)
            {
                FinanciersGridView.Rows[i].Cells[0].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[1].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[2].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[3].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[4].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[5].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[6].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[7].ReadOnly = true;
                FinanciersGridView.Rows[i].Cells[8].ReadOnly = true;




            }

        }
        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
            GetAllFinanciers();
            LockGrid();
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            FinanciersGridView.Rows[e.RowIndex].Cells[0].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[2].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[3].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[4].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[5].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[6].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[7].ReadOnly = false;
            FinanciersGridView.Rows[e.RowIndex].Cells[8].ReadOnly = false;
        }

        private void FinanciersGridView_CommandCellClick(object sender, EventArgs e)
        {
            try{  
        var col = FinanciersGridView.CurrentColumn.Index;
        if (col == 8)
        {
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Thefinancier financ = thefinancierBindingSource.Current as Thefinancier;
               FinanciersCmd.Editfinancier(financ);
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
                       Thefinancier financ = thefinancierBindingSource.Current as Thefinancier;
                       FinanciersCmd.DeleteFinancier(financ.ID);
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

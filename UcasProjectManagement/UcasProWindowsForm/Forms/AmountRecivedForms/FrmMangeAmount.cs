﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddAmount Frm = new FrmAddAmount();
            Frm.ShowDialog();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;

            if (col == 4)
            {
                FrmEditAmount EditAmount = new FrmEditAmount();
                EditAmount.FillCombo();
                EditAmount.XAmountID = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());
                EditAmount.DonorsComboBox.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
                EditAmount.DateOfProecssPicker.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
                EditAmount.CostTextBox.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();



                EditAmount.ShowDialog();
                return;

            }
            if (col == 5)
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
            radGridView1.DataSource = AmountsReceivedsCmd.GetAllAmountsReceivedBypro(InformationsClass.ProjID);
        }
    }
}
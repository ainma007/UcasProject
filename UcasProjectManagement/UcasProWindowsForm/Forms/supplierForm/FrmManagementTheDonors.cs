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

            theDonorsBindingSource.DataSource = TheDonorCmd.GetAllDonors();
        }
        

       
        private void FrmManagementFinanciers_Load(object sender, EventArgs e)
        {
            GetAllFinanciers();
          
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
          
        }

        private void FinanciersGridView_CommandCellClick(object sender, EventArgs e)
        {
            try{  
        var col = DonersGridView.CurrentColumn.Index;
        if (col == 7)
        {
            FrmDonorsEdit frm = new FrmDonorsEdit();
            frm.XDonorsId = int.Parse(DonersGridView.CurrentRow.Cells[0].Value.ToString());
            frm.TheDonorsNameTextBox.Text = DonersGridView.CurrentRow.Cells[1].Value.ToString();
            frm.AgentNameTextBox.Text = DonersGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PhoneNumberTextBox.Text = DonersGridView.CurrentRow.Cells[3].Value.ToString();
            frm.faxTextBox4.Text = DonersGridView.CurrentRow.Cells[4].Value.ToString();
            frm.EmailTextBox.Text = DonersGridView.CurrentRow.Cells[5].Value.ToString();
            frm.AdressTextBox.Text = DonersGridView.CurrentRow.Cells[6].Value.ToString();
            frm.ShowDialog();
            
        }
        if (col == 8) { if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {
                       
                       TheDonorCmd.DeleteDonor(int.Parse(DonersGridView.CurrentRow.Cells[0].Value.ToString()));
                       RadMessageBox.Show(OperationX.DeletedMessage);
                     
                      
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

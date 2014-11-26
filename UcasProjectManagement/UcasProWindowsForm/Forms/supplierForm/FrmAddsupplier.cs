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
using Ucas.Data.Special_Classes;
namespace UcasProWindowsForm.Forms.supplierForm
{
    public partial class FrmAddsupplier : Telerik.WinControls.UI.RadForm
    {
        public FrmAddsupplier()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void FrmAddsupplier_Load(object sender, EventArgs e)
        {
          
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (NameTextBox.Text == "")
            {
                NameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.NameTextBox, "من فضلك ادخل اسم المورد");

                NameTextBox.Focus();

                return;
            }
            else
            {
                NameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion





            Operation.BeginOperation(this);
           

            Supplier Sup=new Supplier()
            {
                Name= NameTextBox.Text,
                SuppliersNatural=SuppliersNaturalTextBox.Text,
                Email=EmailTextBox.Text,
                PhoneNumber=PhoneNumberTextBox.Text,
                Fax=faxTextBox4.Text,
                Adderss=AdressTextBox.Text,



            };
             SuppliersCmd.newSupplier(Sup);
             Operation.EndOperation(this);

          RadMessageBox.Show(this, OperationX.AddMessageDone, "Done", MessageBoxButtons.OK, RadMessageIcon.Info);
          clearText();
        }




        

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void faxTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void clearText()
        {
               NameTextBox.Clear();
               SuppliersNaturalTextBox.Clear();
               EmailTextBox.Clear();
                PhoneNumberTextBox.Clear();
               faxTextBox4.Clear();
               AdressTextBox.Clear();
               NameTextBox.Focus();

            

        }
        }
    
    }


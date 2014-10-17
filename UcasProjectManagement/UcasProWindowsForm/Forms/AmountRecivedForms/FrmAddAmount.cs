﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.AmountRecivedForms
{
    public partial class FrmAddAmount : Telerik.WinControls.UI.RadForm
    {
        public FrmAddAmount()
        {
            InitializeComponent();
        }
        private void FillCombo()
        {
            this.DonorsComboBox.AutoFilter = true;
            this.DonorsComboBox.ValueMember = "ID";
            this.DonorsComboBox.DisplayMember = "Name";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DonorsComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.DonorsComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            DonorsComboBox.DataSource = TheDonorsProjectCmd.GetAllDonorsForAmountsBypro(InformationsClass.ProjID);

        }
        private void FrmAddAmount_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DonorsComboBox.SelectedValue == null)
            {

                DonorsComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;



                DonorsComboBox.Focus();

                return;
            }
            else
            {
                DonorsComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }

            if (CostTextBox.Text == "")
            {

              CostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

               CostTextBox.Focus();

                return;
            }
            else
            {
            CostTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }
            AmountsReceived tb = new AmountsReceived()
            {
                ProjectProfile_ID=InformationsClass.ProjID,
                TheFinancerProjectsID= int.Parse(DonorsComboBox.SelectedValue.ToString()),
                Date=DateOfProecssPicker.Value.Date,
                Cost=Convert.ToDouble(CostTextBox.Text),
                


            };

            AmountsReceivedsCmd.NewAmountsReceived(tb);
            RadMessageBox.Show("Done");
            ClearTextBox();
        }


        private void ClearTextBox()
        {

            DonorsComboBox.ResetText();
            CostTextBox.Clear();
            DonorsComboBox.Focus();


        }
       

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          if ((e.KeyChar < 48 || e.KeyChar > 57) &&

         e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)

        e.Handled = true;

        }

        private void CostTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
                          

        }
       

      
        }
    }

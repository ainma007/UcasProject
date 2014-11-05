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
using Ucas.Data.Special_Classes;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmAddExpenses : Telerik.WinControls.UI.RadForm
    {
        public FrmAddExpenses()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
      
        }
        private void FillComboBox()
        {
            ///تعبئة النشاطات الفرعية
            this.SubActivtiesComboBox.AutoFilter = true;
            this.SubActivtiesComboBox.ValueMember = "ID";
            this.SubActivtiesComboBox.DisplayMember = "SubActivityName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.SubActivtiesComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.SubActivtiesComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            SubActivtiesComboBox.DataSource = SubActivityCmd.GetAllSubActivitiesByProjectID(InformationsClass.ProjID);
            
            //تعبئة الموردين
            this.SupplierComboBox.AutoFilter = true;
            this.SupplierComboBox.ValueMember = "ID";
            this.SupplierComboBox.DisplayMember = "Name";


            FilterDescriptor filter2 = new FilterDescriptor();
            filter2.PropertyName = this.SupplierComboBox.DisplayMember;
            filter2.Operator = FilterOperator.Contains;
            this.SupplierComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter2);
            SupplierComboBox.DataSource = SuppliersCmd.GetAll();
            
        }
        private void FrmAddExpenses_Load(object sender, EventArgs e)
        {
            FillComboBox();
          
        }

        

     
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (SubActivtiesComboBox.SelectedValue == null)
            {

                SubActivtiesComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                SubActivtiesComboBox.Focus();

                return;
            }
            else
            {
                SubActivtiesComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }
            ///
            if (ExpensesNameTextBox.Text == "")
            {

                ExpensesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                ExpensesNameTextBox.Focus();

                return;
            }
            else
            {
                ExpensesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }

            ///
            if (RequiarAmountTextBox.Text == "")
            {

                RequiarAmountTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                RequiarAmountTextBox.Focus();

                return;
            }
            else
            {
                RequiarAmountTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }
           
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ProjectExpens tb = new ProjectExpens
                {
                    ProjectProfile_ID = InformationsClass.ProjID,
                    ProjectSubActivity_ID = int.Parse(SubActivtiesComboBox.SelectedValue.ToString()),
                    ExpensesName = ExpensesNameTextBox.Text,
                    DateofProcess = DateOfProecssPicker.Value.Date,
                    BillNumber = BillTextBox.Text,
                    RequiarAmount = Convert.ToDouble(RequiarAmountTextBox.Text),
                    CashingNumber = CashingNumberTextBox.Text,
                    Supplier_ID = int.Parse(SupplierComboBox.SelectedValue.ToString())



                };

                ProjectExpensesCmd.NewProjectExpens(tb);

                RadMessageBox.Show("تمت علمية الاضافة");
                this.Cursor = Cursors.Default;
                ClearTxt();
            }
            catch (Xprema.XpremaException ex)
            {
                this.Cursor = Cursors.Default;
                RadMessageBox.Show(ex.OtherDescription);

            }
        }
        private void ClearTxt()
        {
            ExpensesNameTextBox.Clear();
            BillTextBox.Clear();
            RequiarAmountTextBox.Clear();
            CashingNumberTextBox.Clear();
            SupplierComboBox.ResetText();
            SubActivtiesComboBox.Focus();

        }
        private void RequiarAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && RequiarAmountTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
      

    }
}

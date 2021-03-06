﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;
using System.Threading;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmEditExpense : Telerik.WinControls.UI.RadForm
    {
        public FrmEditExpense()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public int XExpID { get; set; }
        public Ucas.Data.ProjectExpens TragetExpens { get; set; }
        Thread th;
        private void FillComboBox()
        {
            Operation.BeginOperation(this);
            this.SubActivtiesComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

            this.SupplierComboBox.MultiColumnComboBoxElement.DropDownWidth = 300;
            this.Invoke((MethodInvoker)delegate
            {
                this.SubActivtiesComboBox.AutoFilter = true;
                this.SubActivtiesComboBox.ValueMember = "ID";
                this.SubActivtiesComboBox.DisplayMember = "SubActivityName";
                ///
                this.SupplierComboBox.AutoFilter = true;
                this.SupplierComboBox.ValueMember = "ID";
                this.SupplierComboBox.DisplayMember = "Name";

            });
            var q = SubActivityCmd.GetAllSubActivitiesByProjectID(InformationsClass.ProjID);
            var q1 = SuppliersCmd.GetAll();
            this.Invoke((MethodInvoker)delegate
            {  ///تعبئة النشاطات الفرعية
                SubActivtiesComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.SubActivtiesComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.SubActivtiesComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
                //تعبئة الموردين
                SupplierComboBox.DataSource = q1;
                FilterDescriptor filter2 = new FilterDescriptor();
                filter2.PropertyName = this.SupplierComboBox.DisplayMember;
                filter2.Operator = FilterOperator.Contains;
                this.SupplierComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter2);
                ////////FillText
                XExpID = TragetExpens.ID;
                SubActivtiesComboBox.Text = TragetExpens.ProjectSubActivity.SubActivityName;
                ExpensesNameTextBox.Text = TragetExpens.ExpensesName;
                BillTextBox.Text = TragetExpens.BillNumber;
                CashingNumberTextBox.Text = TragetExpens.CashingNumber;
                DateOfProecssPicker.Text = TragetExpens.DateofProcess.ToString();
                RequiarAmountTextBox.Text = TragetExpens.RequiarAmount.ToString();
                SupplierComboBox.Text = TragetExpens.Supplier.Name;
            });
            Operation.EndOperation(this);
           
          

            th.Abort();
        }
        private void FrmEditExpense_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(FillComboBox);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (SubActivtiesComboBox.Text == "")
            {

                SubActivtiesComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.SubActivtiesComboBox, "من فضلك ادخل النشاط");
                SubActivtiesComboBox.Focus();

                return;
            }
            else
            {
                SubActivtiesComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (SubActivtiesComboBox.SelectedValue == null)
            {

                SubActivtiesComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.SubActivtiesComboBox, "من فضلك ادخل النشاط");
                SubActivtiesComboBox.Focus();

                return;
            }
            else
            {
                SubActivtiesComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///
            if (ExpensesNameTextBox.Text == "")
            {

                ExpensesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.ExpensesNameTextBox, "من فضلك ادخل المصروف");

                ExpensesNameTextBox.Focus();

                return;
            }
            else
            {
                ExpensesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            ///
            if (RequiarAmountTextBox.Text == "")
            {

                RequiarAmountTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.RequiarAmountTextBox, "من فضلك ادخل المبلغ");


                RequiarAmountTextBox.Focus();

                return;
            }
            else
            {
                RequiarAmountTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }


            ////


            if (SupplierComboBox.Text == "")
            {

                SupplierComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.SupplierComboBox, "من فضلك ادخل المورد");
                SupplierComboBox.Focus();

                return;
            }
            else
            {
                SupplierComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (SupplierComboBox.SelectedValue == null)
            {

                SupplierComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.SupplierComboBox, "من فضلك ادخل المورد");
                SupplierComboBox.Focus();

                return;
            }
            else
            {
                SupplierComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Operation.BeginOperation(this);
                   

                    ProjectExpens tb = new ProjectExpens
                    {
                         
                        ID = XExpID,
                        ProjectSubActivity_ID = int.Parse(SubActivtiesComboBox.SelectedValue.ToString()),
                        ExpensesName = ExpensesNameTextBox.Text,
                        BillNumber = BillTextBox.Text,
                        DateofProcess = DateOfProecssPicker.Value.Date,
                        CashingNumber = CashingNumberTextBox.Text,
                        RequiarAmount = Convert.ToDouble(RequiarAmountTextBox.Text),
                        Supplier_ID = int.Parse(SupplierComboBox.SelectedValue.ToString()),


                    };
                    ProjectExpensesCmd.EditProjectExpens(tb);
                    Operation.EndOperation(this);
                    RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                    GC.SuppressFinalize(th);
                    GC.SuppressFinalize(tb);
                    GC.Collect();
                    GC.WaitForFullGCComplete();
                    GC.WaitForPendingFinalizers();
                    this.Dispose();
                }
                catch (Xprema.XpremaException ex)
                {
                    Operation.EndOperation(this);
                    RadMessageBox.Show(ex.OtherDescription, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                }
            }
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

        private void FrmEditExpense_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}

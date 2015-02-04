using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.ExpensesForm
{
    public partial class FrmAddExpenses : Telerik.WinControls.UI.RadForm
    {
        public FrmAddExpenses()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
      
        }
        Thread th;
        private void FillComboBox()
        {
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.SubActivtiesComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.SupplierComboBox.MultiColumnComboBoxElement.DropDownWidth = 300;

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
            });
            Operation.EndOperation(this);
            th.Abort();
   
        }
        private void FrmAddExpenses_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(FillComboBox);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            DateOfProecssPicker.Value = DateTime.Now;
          
            
          
        }

        

     
        private void AddBtn_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);
           
            try
            {
               
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
                Operation.EndOperation(this);

                Operation.ShowToustOk(OperationX.AddMessageDone, this);
                GC.SuppressFinalize(tb);

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                ClearTxt();
            }
            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(ex.OtherDescription, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

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

        private void FrmAddExpenses_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);

            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
      

    }
}

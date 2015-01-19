using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmTheDonorsAndProjectEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        public int XDonrPro { get; set; }
        public Ucas.Data.TheDonorsProject TragetTheDonorsProject { get; set; }
        private void fillDonorsCombo()
        {

            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.DonorsColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.DonorsColumnComboBox.AutoFilter = true;
                this.DonorsColumnComboBox.ValueMember = "ID";
                this.DonorsColumnComboBox.DisplayMember = "Name";
            });
            var q = TheDonorCmd.GetAllDonors();
            this.Invoke((MethodInvoker)delegate
            {
                DonorsColumnComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.DonorsColumnComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.DonorsColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
                XDonrPro = TragetTheDonorsProject.ID;
                DonorsColumnComboBox.Text = TragetTheDonorsProject.TheDonor.Name;
                CostTextBox.Text = TragetTheDonorsProject.TotalCost.ToString();
            });
            Operation.EndOperation(this);

            th.Abort();







        }
        private void FrmTheDonorsAndProjectEdit_Load(object sender, EventArgs e)


        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(fillDonorsCombo);
            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
           

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region "  CheckFillTextBox "
                if (DonorsColumnComboBox.SelectedValue == null)
                {
                    DonorsColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                    errorProvider1.SetError(this.DonorsColumnComboBox, "من فضلك ادخل اسم الممول");

                    DonorsColumnComboBox.Focus();

                    return;
                }
                else
                {
                    DonorsColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                }

                if (CostTextBox.Text == "")
                {

                    CostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                    errorProvider1.SetError(this.CostTextBox, "من فضلك ادخل  الميزانية");

                    CostTextBox.Focus();

                    return;
                }
                else
                {

                    CostTextBox.TextBoxElement.Fill.BackColor = Color.White;
                    errorProvider1.Clear();
                }


                #endregion
                if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);


                    TheDonorsProject tb = new TheDonorsProject()
                    {
                        ID = XDonrPro,
                        ProjectID = InformationsClass.ProjID,
                        DonorsID = int.Parse(DonorsColumnComboBox.SelectedValue.ToString()),
                        TotalCost = Convert.ToDouble(CostTextBox.Text)

                    };

                    TheDonorsProjectCmd.EditTheDonorsProject(tb);
                    Operation.EndOperation(this);
                    RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                    GC.SuppressFinalize(th);
                    GC.SuppressFinalize(tb);
                    GC.Collect();
                    GC.WaitForFullGCComplete();
                    GC.WaitForPendingFinalizers();
                    this.Dispose();
                }
            }
            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(ex.UserDescriptionArabic, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && CostTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void FrmTheDonorsAndProjectEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}
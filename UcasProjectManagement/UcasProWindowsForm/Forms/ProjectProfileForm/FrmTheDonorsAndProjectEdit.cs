using System;
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

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmTheDonorsAndProjectEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public int XDonrPro { get; set; }
        public Ucas.Data.TheDonorsProject TragetTheDonorsProject { get; set; }
        public void fillDonorsCombo()
        {
            this.DonorsColumnComboBox.AutoFilter = true;
            this.DonorsColumnComboBox.ValueMember = "ID";
            this.DonorsColumnComboBox.DisplayMember = "Name";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DonorsColumnComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.DonorsColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            DonorsColumnComboBox.DataSource = TheDonorCmd.GetAllDonors();


        }
        private void FrmTheDonorsAndProjectEdit_Load(object sender, EventArgs e)


        {
            fillDonorsCombo();
            XDonrPro = TragetTheDonorsProject.ID;
            DonorsColumnComboBox.Text = TragetTheDonorsProject.TheDonor.Name;
            CostTextBox.Text = TragetTheDonorsProject.TotalCost.ToString();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
                this.Close();
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;


namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmTheDonorsAndProjectAdd : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectAdd()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        private void fillDonorsCombo()
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
        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (DonorsColumnComboBox.SelectedValue == null)
            {
                DonorsColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                DonorsColumnComboBox.Focus();

                return;
            }
            else
            {
                DonorsColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }
            TheDonorsProject tb = new TheDonorsProject()
            {

                ProjectID = InformationsClass.ProjID,
                DonorsID = int.Parse(DonorsColumnComboBox.SelectedValue.ToString()),
                TotalCost = Convert.ToDouble(CostTextBox.Text)

            };

            TheDonorsProjectCmd.AddTheTheDonorsProject(tb);
            MessageBox.Show("تمت العملية بنجاح");
           
        }

        private void FrmTheDonorsAndProjectAdd_Load(object sender, EventArgs e)
        {
            fillDonorsCombo();
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

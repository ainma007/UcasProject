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

           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
            if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                TheDonorsProject tb = new TheDonorsProject()
                {
                    ID = XDonrPro,
                    ProjectID = InformationsClass.ProjID,
                    DonorsID = int.Parse(DonorsColumnComboBox.SelectedValue.ToString()),
                    TotalCost = Convert.ToDouble(CostTextBox.Text)

                };

                TheDonorsProjectCmd.EditTheDonorsProject(tb);
                MessageBox.Show("تمت العملية بنجاح");
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
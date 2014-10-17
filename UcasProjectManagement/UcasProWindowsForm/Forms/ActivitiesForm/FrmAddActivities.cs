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

namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    public partial class FrmAddActivities : Telerik.WinControls.UI.RadForm
    {
        public FrmAddActivities()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (ActivitiesNameTextBox.Text == "")
            {

                ActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                ActivitiesNameTextBox.Focus();

                return;
            }
            else
            {
                ActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }
            if (TotalCostTextBox.Text == "")
            {

                TotalCostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                TotalCostTextBox.Focus();

                return;
            }
            else
            {
                TotalCostTextBox.TextBoxElement.Fill.BackColor = Color.White;
            }


            ProjectActivity tb = new ProjectActivity()
            {

                ProjectProfile_ID = InformationsClass.ProjID,
                ActivityName = ActivitiesNameTextBox.Text,
                Description = ActivitiesDescriptionTextBox.Text,
                StartDate = DateTime.Parse(StartDateTimePicker.Value.Date.ToString()),
                EndDate = DateTime.Parse(EndDateTimePicker.Value.Date.ToString()),
                Status = "فعال",
                Progress = 0,
                TotalCost = Convert.ToDouble(TotalCostTextBox.Text),
                
            };

            ActivityCmd.NewActivity(tb);
            MessageBox.Show("تمت عملية الاضافة");
            ClearTxt();
        }
        private void ClearTxt()
        {
                ActivitiesNameTextBox.Clear();
                ActivitiesDescriptionTextBox.Clear();
                TotalCostTextBox.Clear();
                ActivitiesNameTextBox.Focus();
        }
        private void FrmAddActivities_Load(object sender, EventArgs e)
        {

        }

        private void TotalCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && TotalCostTextBox.Text.IndexOf(".") != -1)
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

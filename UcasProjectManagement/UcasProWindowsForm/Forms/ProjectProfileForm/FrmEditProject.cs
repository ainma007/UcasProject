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

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmEditProject : Telerik.WinControls.UI.RadForm
    {

        public FrmEditProject()
        {
            InitializeComponent();
        }
        public int XProID { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (ProjectNameTextBox.Text == "")
            {

                ProjectNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                ProjectNameTextBox.Focus();

                return;
            }
            else
            {
                ProjectNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
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

            if (RadMessageBox.Show(this, OperationX.SaveMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                ProjectProfile pro = new ProjectProfile()
                {
                    ID = XProID,
                    ProjectName = ProjectNameTextBox.Text,
                    ProjectDescription = ProjectDescriptionTextBox.Text,
                    StartDate = DateTime.Parse(StartDateTimePicker.Value.ToString()),
                    EndDate = DateTime.Parse(EndDateTimePicker.Value.ToString()),
                    TotalCost = Double.Parse(TotalCostTextBox.Text),
                    Status = StatusDownList.Text,

                    Coin = CoineDropDownList.SelectedItem.ToString()




                };
                ProjectProfileCmd.EditProjectProfile(pro);
                MessageBox.Show("تمت العلمية بنجاح");
            }
        }
    }
}
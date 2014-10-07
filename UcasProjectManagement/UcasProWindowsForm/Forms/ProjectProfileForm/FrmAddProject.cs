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
    public partial class FrmAddProject : Telerik.WinControls.UI.RadForm
    {
     
        private UcasProEntities Ucas = new UcasProEntities();
        public FrmAddProject()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
           
        }
      
        
        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
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

            if (CoineDropDownList.SelectedItem == null)
            {
                //GenderDropDownList.BackColor = System.Drawing.Color.Red;
                CoineDropDownList.DropDownListElement.TextBox.BackColor = Color.OrangeRed;
                // GenderDropDownList.DropDownListElement.TextBox.Fill.BackColor = Color.OrangeRed;


                CoineDropDownList.Focus();

                return;
            }
            else
            {
                CoineDropDownList.DropDownListElement.TextBox.BackColor = Color.White;
            }
            ProjectProfile pro = new ProjectProfile()
            {
                
                ProjectName = ProjectNameTextBox.Text,
                ProjectDescription = ProjectDescriptionTextBox.Text,
                StartDate = DateTime.Parse(StartDateTimePicker.Value.ToString()),
                EndDate = DateTime.Parse(EndDateTimePicker.Value.ToString()),
                TotalCost = Double.Parse(TotalCostTextBox.Text),
                Status = "فعال",
                progress = 0,
                Coin = CoineDropDownList.SelectedItem.ToString()




            };
            ProjectProfileCmd.AddNewProject(pro);
            ClearText();
            MessageBox.Show("تمت العلمية بنجاح");
        }

        private void ClearText()
        {
            ProjectNameTextBox.Clear();
            ProjectDescriptionTextBox.Clear();
            TotalCostTextBox.Clear();
            CoineDropDownList.ResetText();
            ProjectNameTextBox.Focus();


            
        }

        private void FrmAddProject_Load(object sender, EventArgs e)
        {

        }
    }
}

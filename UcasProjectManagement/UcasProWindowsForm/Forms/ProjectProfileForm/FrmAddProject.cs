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
           
        }
      
        
        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        { 
            ProjectProfile pro = new ProjectProfile()
            {
                
                ProjectName = ProjectNameTextBox.Text,
                ProjectDescription = ProjectDescriptionTextBox.Text,
                StartDate = DateTime.Parse(StartDateTimePicker.Value.ToString()),
                EndDate = DateTime.Parse(EndDateTimePicker.Value.ToString()),
                TotalCost = Double.Parse(TotalCostTextBox.Text),
                Status = "1",
                progress = 0,
                Coin = CoineDropDownList.SelectedItem.ToString(),




            };
            ProjectProfileCmd.AddNewProject(pro);
            MessageBox.Show("تمت العلمية بنجاح");
        }
    }
}

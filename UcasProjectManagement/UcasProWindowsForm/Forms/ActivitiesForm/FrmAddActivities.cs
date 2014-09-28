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
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ProjectActivity tb = new ProjectActivity()
            {

                ProjectProfile_ID = InformationsClass.ProjID,
                ActivityName = ActivitiesNameTextBox.Text,
                Description = ActivitiesDescriptionTextBox.Text,
                StartDate = DateTime.Parse(StartDateTimePicker.Value.Date.ToString()),
                EndDate = DateTime.Parse(EndDateTimePicker.Value.Date.ToString()),
                Status = "فعال",
                Progress = 0,
                TotalCost = Convert.ToDouble(TotalCostTextBox.Text)
            };

            ActivityCmd.NewActivity(tb);
            MessageBox.Show("تمت عملية الاضافة");
        }
    }
}

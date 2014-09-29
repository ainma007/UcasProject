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

namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    public partial class FrmAddSubActivities : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSubActivities()
        {
            InitializeComponent();
        }
        private void FillActivty()
        {


            ///GetActivityByProjectID
            this.ActivitiesColumnComboBox.AutoFilter = true;
            this.ActivitiesColumnComboBox.ValueMember = "ID";
            this.ActivitiesColumnComboBox.DisplayMember = "ActivityName";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.ActivitiesColumnComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.ActivitiesColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            ActivitiesColumnComboBox.DataSource = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
        }
        private void FrmAddSubActivities_Load(object sender, EventArgs e)
        {
            FillActivty();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ProjectSubActivity tb = new ProjectSubActivity()
            {

                ProjectActivity_ID=int.Parse(ActivitiesColumnComboBox.SelectedValue.ToString()),
                SubActivityName=SubActivitiesNameTextBox.Text,
                Description=SubActivitiesDescriptionTextBox.Text,
                Startdate=DateTime.Parse(StartDateTimePicker.Value.ToString()),
                enddate=DateTime.Parse(EndDateTimePicker.Value.Date.ToString()),
                Status="فعال",
                Progress=0,
                TotalCost=Convert.ToDouble(TotalCostTextBox.Text),


            };
            SubActivityCmd.NewSubActivity(tb);
            MessageBox.Show("Saved...");
        }
    }
}

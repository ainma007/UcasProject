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
            RadMessageBox.SetThemeName("TelerikMetro");
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
            if (ActivitiesColumnComboBox.SelectedValue == null)
            {
                //GenderDropDownList.BackColor = System.Drawing.Color.Red;
                ActivitiesColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                // GenderDropDownList.DropDownListElement.TextBox.Fill.BackColor = Color.OrangeRed;


                ActivitiesColumnComboBox.Focus();

                return;
            }
            else
            {
                ActivitiesColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }

            if (SubActivitiesNameTextBox.Text == "")
            {

                SubActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                SubActivitiesNameTextBox.Focus();

                return;
            }
            else
            {
                SubActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
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

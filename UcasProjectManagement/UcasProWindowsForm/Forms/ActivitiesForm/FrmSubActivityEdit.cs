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

namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    public partial class FrmSubActivityEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmSubActivityEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public int SubXid { get; set; }
        public void FillActivty()
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
        private void FrmSubActivityEdit_Load(object sender, EventArgs e)
        {
            ProgressEditor.Maximum = 100;
            ProgressEditor.Minimum = 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
         if (RadMessageBox.Show(this, OperationX.SaveMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
         {
             ProjectSubActivity tb = new ProjectSubActivity()

             {
                 ID = SubXid,
                 ProjectActivity_ID = int.Parse(ActivitiesColumnComboBox.SelectedValue.ToString()),
                 SubActivityName = SubActivitiesNameTextBox.Text,
                 Description = SubActivitiesDescriptionTextBox.Text,
                 Startdate = StartDateTimePicker.Value.Date,
                 enddate = EndDateTimePicker.Value.Date,
                 TotalCost = Convert.ToDouble(TotalCostTextBox.Text),
                 Progress = int.Parse(ProgressEditor.Value.ToString()),
                 Status = StatusDropDownList.Text,




             };
             SubActivityCmd.EditSubActivity(tb);
             MessageBox.Show("تمت عملية التعديل");
         }
        }
           
    }
}

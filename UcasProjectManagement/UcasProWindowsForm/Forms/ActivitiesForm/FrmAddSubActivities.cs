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

            #region "  CheckFillTextBox "

            if (ActivitiesColumnComboBox.SelectedValue == null)
            {

                ActivitiesColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.ActivitiesColumnComboBox, "من فضلك ادخل النشاط الرئيسي");
                ActivitiesColumnComboBox.Focus();


                return;
            }
            else
            {
                ActivitiesColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (SubActivitiesNameTextBox.Text == "")
            {

                SubActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.SubActivitiesNameTextBox, "من فضلك ادخل اسم النشاط");

                SubActivitiesNameTextBox.Focus();

                return;
            }
            else
            {
                SubActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (TotalCostTextBox.Text == "")
            {

                TotalCostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.TotalCostTextBox, "من فضلك ادخل المبلغ");

                TotalCostTextBox.Focus();

                return;
            }
            else
            {
                TotalCostTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }
            #endregion


            Operation.BeginOperation(this);
           

            try
            {
                ProjectSubActivity tb = new ProjectSubActivity()
                {

                    ProjectActivity_ID = int.Parse(ActivitiesColumnComboBox.SelectedValue.ToString()),
                    SubActivityName = SubActivitiesNameTextBox.Text,
                    Description = SubActivitiesDescriptionTextBox.Text,
                    Startdate = DateTime.Parse(StartDateTimePicker.Value.ToString()),
                    enddate = DateTime.Parse(EndDateTimePicker.Value.Date.ToString()),
                    Status = "فعال",
                    Progress = 0,
                    TotalCost = Convert.ToDouble(TotalCostTextBox.Text),
                    ProjectProfile_ID = InformationsClass.ProjID,


                };
                SubActivityCmd.NewSubActivity(tb);
                Operation.EndOperation(this);
                RadMessageBox.Show(OperationX.AddMessageDone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                ClearTxt();
            }
            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(this, ex.OtherDescription, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

            }

        }

        private void ClearTxt()
        {
            SubActivitiesNameTextBox.Clear();
            SubActivitiesDescriptionTextBox.Clear();
            TotalCostTextBox.Clear();
            TotalCostTextBox.Focus();
        }
      
        private void TotalCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch== 46 && TotalCostTextBox.Text.IndexOf(".")  !=-1)
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

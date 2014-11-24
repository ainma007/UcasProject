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
             try
             {
                 this.Cursor = Cursors.WaitCursor;
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
                 this.Cursor = Cursors.Default;
                 MessageBox.Show("تمت عملية التعديل");
             }
             catch (Xprema.XpremaException ex)
             {

                 RadMessageBox.Show(ex.OtherDescription);
                
             }
         }
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

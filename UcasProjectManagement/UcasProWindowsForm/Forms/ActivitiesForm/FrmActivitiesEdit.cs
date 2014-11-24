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
    public partial class FrmActivitiesEdit : Telerik.WinControls.UI.RadForm
    {
          
        public int xID { get; set; }
        public FrmActivitiesEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void FrmActivitiesEdit_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (ActivitiesNameTextBox.Text == "")
            {

                ActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.ActivitiesNameTextBox, "من فضلك ادخل النشاط");

                ActivitiesNameTextBox.Focus();

                return;
            }
            else
            {
                ActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
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
            
              if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Operation.BeginOperation(this);
                    ProjectActivity tb = new ProjectActivity()
                    {


                        ID = xID,
                        ActivityName = ActivitiesNameTextBox.Text,
                        Description = ActivitiesDescriptionTextBox.Text,
                        StartDate = StartDateTimePicker.Value.Date,
                        EndDate = EndDateTimePicker.Value.Date,
                        TotalCost = Convert.ToDouble(TotalCostTextBox.Text),
                        Status = StatusDropDownList.Text,


                    };
                    ActivityCmd.EditActivity(tb);
                    Operation.EndOperation(this);
                    RadMessageBox.Show("تمت عملية التعديل");
                    this.Close();
                }
                catch (Xprema.XpremaException ex)
                {
                    Operation.EndOperation(this);
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

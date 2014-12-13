﻿using System;
using System.Drawing;
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
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void AddBtn_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);
            
            try
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
                    TotalCost = Convert.ToDouble(TotalCostTextBox.Text),

                };

                ActivityCmd.NewActivity(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk(OperationX.AddMessageDone, this);
                ClearTxt();
            }
            catch (Xprema.XpremaException ex)
            {
                Operation.EndOperation(this);
                RadMessageBox.Show(this,ex.OtherDescription,"خطأ",MessageBoxButtons.OK,RadMessageIcon.Error);

            }
        }
        
        private void ClearTxt()
        {
                ActivitiesNameTextBox.Clear();
                ActivitiesDescriptionTextBox.Clear();
                TotalCostTextBox.Clear();
                ActivitiesNameTextBox.Focus();
        }
        private void FrmAddActivities_Load(object sender, EventArgs e)
        {
            Coinlabel.Text = InformationsClass.Coin;
            StartDateTimePicker.Value = DateTime.Now;
            EndDateTimePicker.Value = DateTime.Now;
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

        private void FrmAddActivities_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

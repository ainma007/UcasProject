﻿using System;
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
        }

        private void FrmActivitiesEdit_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (ActivitiesNameTextBox.Text == "")
            {

                ActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;

                ActivitiesNameTextBox.Focus();

                return;
            }
            else
            {
                ActivitiesNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
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

            if (StatusDropDownList.SelectedItem == null)
            {
                //GenderDropDownList.BackColor = System.Drawing.Color.Red;
                StatusDropDownList.DropDownListElement.TextBox.BackColor = Color.OrangeRed;
                // GenderDropDownList.DropDownListElement.TextBox.Fill.BackColor = Color.OrangeRed;


                StatusDropDownList.Focus();

                return;
            }
            else
            {
                StatusDropDownList.DropDownListElement.TextBox.BackColor = Color.White;
            }
            ProjectActivity tb = new ProjectActivity()
            {


                ID = xID,
                ActivityName=ActivitiesNameTextBox.Text,
                Description=ActivitiesDescriptionTextBox.Text,
                StartDate=StartDateTimePicker.Value.Date,
                EndDate=EndDateTimePicker.Value.Date,
                TotalCost=Convert.ToDouble (TotalCostTextBox.Text),
                Status=StatusDropDownList.Text,


            };
            ActivityCmd.EditActivity(tb);
            MessageBox.Show("Saved");
        }
    }
}

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
    public partial class frmUserEditProject : Telerik.WinControls.UI.RadForm
    {
        public frmUserEditProject()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        public int ProId { get; set; }
        private void frmUserEditProject_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (ProjectNameTextBox.Text == "")
            {

                ProjectNameTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.ProjectNameTextBox, "من فضلك ادخل اسم المشروع");
                ProjectNameTextBox.Focus();

                return;
            }
            else
            {
                ProjectNameTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (TotalCostTextBox.Text == "")
            {

                TotalCostTextBox.TextBoxElement.Fill.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.TotalCostTextBox, "من فضلك ادخل  الميزانية");

                TotalCostTextBox.Focus();

                return;
            }
            else
            {
                TotalCostTextBox.TextBoxElement.Fill.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (CoineDropDownList.Text == null)
            {

                CoineDropDownList.DropDownListElement.TextBox.BackColor = Color.OrangeRed;
                errorProvider1.SetError(this.CoineDropDownList, "من فضلك ادخل  العملة");


                CoineDropDownList.Focus();

                return;
            }
            else
            {
                CoineDropDownList.DropDownListElement.TextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion

            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Operation.BeginOperation(this);


                    ProjectProfile pro = new ProjectProfile()
                    {
                        ID = ProId,
                        ProjectName = ProjectNameTextBox.Text,
                        ProjectDescription = ProjectDescriptionTextBox.Text,
                        StartDate = DateTime.Parse(StartDateTimePicker.Value.ToString()),
                        EndDate = DateTime.Parse(EndDateTimePicker.Value.ToString()),
                        TotalCost = Double.Parse(TotalCostTextBox.Text),
                        Status = StatustextBox.Text,
                        Coin = CoineDropDownList.Text.ToString()




                    };
                    ProjectProfileCmd.EditProjectProfile(pro);
                    Operation.EndOperation(this);
                    RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);

                    this.Dispose();
                }
                catch (Xprema.XpremaException ex)
                {
                    Operation.EndOperation(this);
                    RadMessageBox.Show(this, ex.OtherDescription, "", MessageBoxButtons.OK, RadMessageIcon.Error);


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

        private void frmUserEditProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

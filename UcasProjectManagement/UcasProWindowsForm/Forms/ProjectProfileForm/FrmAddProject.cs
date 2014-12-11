using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmAddProject : Telerik.WinControls.UI.RadForm
    {
     
        private UcasProEntities Ucas = new UcasProEntities();
        public FrmAddProject()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
           
        }
      
        
     
              private void AddBtn_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);
            

            ProjectProfile pro = new ProjectProfile()
            {
                
                ProjectName = ProjectNameTextBox.Text,
                ProjectDescription = ProjectDescriptionTextBox.Text,
                StartDate = DateTime.Parse(StartDateTimePicker.Value.ToString()),
                EndDate = DateTime.Parse(EndDateTimePicker.Value.ToString()),
                TotalCost = Double.Parse(TotalCostTextBox.Text),
                Status = "فعال",
                progress = 0,
                Coin = CoineDropDownList.SelectedItem.ToString()




            };
            ProjectProfileCmd.AddNewProject(pro);
            Operation.EndOperation(this);

            Operation.ShowToustOk(OperationX.AddMessageDone, this);

            ClearText();
           
        }

        private void ClearText()
        {
            ProjectNameTextBox.Clear();
            ProjectDescriptionTextBox.Clear();
            TotalCostTextBox.Clear();
            CoineDropDownList.ResetText();
            ProjectNameTextBox.Focus();


            
        }

        private void FrmAddProject_Load(object sender, EventArgs e)
        {
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
    }
}

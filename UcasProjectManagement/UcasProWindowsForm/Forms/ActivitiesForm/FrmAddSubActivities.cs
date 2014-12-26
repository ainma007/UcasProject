using System;
using System.Drawing;
using System.Threading;
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
        Thread th;
        public void FillActivty()
        {

            Operation.BeginOperation(this);
            ///GetActivityByProjectID
            this.Invoke((MethodInvoker)delegate
            {
                this.ActivitiesColumnComboBox.AutoFilter = true;
                this.ActivitiesColumnComboBox.ValueMember = "ID";
                this.ActivitiesColumnComboBox.DisplayMember = "ActivityName";
            });


            var q = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);



            this.Invoke((MethodInvoker)delegate
            {
                ActivitiesColumnComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.ActivitiesColumnComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.ActivitiesColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);



            });

            Operation.EndOperation(this);
            th.Abort();



        }
        private void FrmAddSubActivities_Load(object sender, EventArgs e)
        {
            th = new Thread(FillActivty);

            th.Start();
            Coinlabel.Text = InformationsClass.Coin;
            StartDateTimePicker.Value = DateTime.Now;
            EndDateTimePicker.Value = DateTime.Now;
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
                Operation.ShowToustOk(OperationX.AddMessageDone, this);
                ClearTxt();
                GC.SuppressFinalize(tb);
                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
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

        private void FrmAddSubActivities_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
        }
    }
}

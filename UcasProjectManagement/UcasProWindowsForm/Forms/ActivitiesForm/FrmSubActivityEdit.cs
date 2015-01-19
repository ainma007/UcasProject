using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data.CommandClass;
using Ucas.Data;
using System.Threading;

namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    public partial class FrmSubActivityEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmSubActivityEdit()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        public int SubXid { get; set; }
        public ProjectSubActivity TragetSUBActivity { get; set; }
        public void FillActivty()
        {

            Operation.BeginOperation(this);
            ///GetActivityByProjectID
            ///
            this.Invoke((MethodInvoker)delegate {
            this.ActivitiesColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

            this.ActivitiesColumnComboBox.AutoFilter = true;
            this.ActivitiesColumnComboBox.ValueMember = "ID";
            this.ActivitiesColumnComboBox.DisplayMember = "ActivityName";
            });
           
           
             var q  = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
            

        
             this.Invoke((MethodInvoker)delegate {
            ActivitiesColumnComboBox.DataSource = q;
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.ActivitiesColumnComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.ActivitiesColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

           
            Coinlabel.Text = InformationsClass.Coin;
            SubXid = TragetSUBActivity.ID;
            ActivitiesColumnComboBox.Text = TragetSUBActivity.ProjectActivity.ActivityName;
            SubActivitiesNameTextBox.Text = TragetSUBActivity.SubActivityName;
            SubActivitiesDescriptionTextBox.Text = TragetSUBActivity.Description;
            StartDateTimePicker.Text = TragetSUBActivity.Startdate.ToString();
            EndDateTimePicker.Text = TragetSUBActivity.enddate.ToString();
            StatusDropDownList.Text = TragetSUBActivity.Status;
            TotalCostTextBox.Text = TragetSUBActivity.TotalCost.ToString();
            ProgressEditor.Value = int.Parse(TragetSUBActivity.Progress.ToString());
            ProgressEditor.Maximum = 100;
            ProgressEditor.Minimum = 0;
          
          });

          Operation.EndOperation(this);

          th.Abort();

           
        }
        private void FrmSubActivityEdit_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            th = new Thread(FillActivty);
            th.Start();
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

            if (RadMessageBox.Show(this, OperationX.SaveMessage, "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
         {
             try
             {
                 Operation.BeginOperation(this);
             

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

                 RadMessageBox.Show(OperationX.SaveMessagedone, "نجاح العملية", MessageBoxButtons.OK,RadMessageIcon.Info);

                 Operation.EndOperation(this);
                 GC.SuppressFinalize(th);
                 GC.SuppressFinalize(tb);
                 GC.Collect();
                 GC.WaitForFullGCComplete();
                 GC.WaitForPendingFinalizers();
                 this.Dispose();
             }
             catch (Xprema.XpremaException ex)
             {
                 Operation.EndOperation(this);
                 RadMessageBox.Show(this, ex.OtherDescription, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
               
                
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

        private void FrmSubActivityEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
        }
           
    }
}

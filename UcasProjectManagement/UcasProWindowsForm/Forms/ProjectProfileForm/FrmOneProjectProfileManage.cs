using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Ucas.Data.CommandClass;
using Ucas.Data;
using UcasProWindowsForm.Forms.MainForm;

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmOneProjectProfileManage : Telerik.WinControls.UI.RadForm
    {
        public FrmOneProjectProfileManage()
        {
            InitializeComponent();
        }
        public int Xid { get; set; }
        private void fillDonorsCombo()
        {
            this.DonarsColumnComboBox.AutoFilter = true;
            this.DonarsColumnComboBox.ValueMember = "ID";
            this.DonarsColumnComboBox.DisplayMember = "Name";


            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DonarsColumnComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.DonarsColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            DonarsColumnComboBox.DataSource = TheDonorsCmd.GetAllDonors();


        }
        private void FrmOneProjectProfileManage_Load(object sender, EventArgs e)
        {
            fillDonorsCombo();
            DonorsSaveBtn.Enabled = false;
            radGridView1.DataSource = TheDonorsProjectCmd.GetAllDonorsBypro(InformationsClass.ProjID);

        }

       
        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {

            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.Xid = int.Parse((currentRow.Cells[0].Value.ToString()));
                this.DonarsColumnComboBox.Text = (currentRow.Cells[1].Value.ToString());
                this.DonorCostTextBox.Text = (currentRow.Cells[2].Value.ToString());

                DonorsSaveBtn.Enabled = true;



            }

        }
        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdatePanelInfo(this.radGridView1.CurrentRow, 5);
        }

        private void DonorsSaveBtn_Click(object sender, EventArgs e)
        {
            TheDonorsProject Dpro = new TheDonorsProject()
            {
                ID = Xid,
                DonorsID=int.Parse(DonarsColumnComboBox.SelectedValue.ToString()),
                TotalCost =Convert.ToDouble(DonorCostTextBox.Text)


            };
            TheDonorsProjectCmd.EditTheDonorsProject(Dpro);
            radGridView1.DataSource = TheDonorsProjectCmd.GetAllDonorsBypro(InformationsClass.ProjID);

            MessageBox.Show("تمت عملية التعديل ");
            DonorsSaveBtn.Enabled = false;
        }

        private void DonorAddBtn_Click(object sender, EventArgs e)
        {
            FrmTheDonorsAndProjectAdd frmAdd = new FrmTheDonorsAndProjectAdd();
            frmAdd.ShowDialog();
        }
    }
}
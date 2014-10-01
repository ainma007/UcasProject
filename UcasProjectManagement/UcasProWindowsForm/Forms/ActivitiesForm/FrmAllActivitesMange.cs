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
    public partial class FrmAllActivitesMange : Telerik.WinControls.UI.RadForm
    {
        public FrmAllActivitesMange()
        {
            InitializeComponent();
        }
        UcasProEntities db = new UcasProEntities();
        private void AdActivitesBtn_Click(object sender, EventArgs e)
        {
            FrmAddActivities AddActivfrm = new FrmAddActivities();
            AddActivfrm.ShowDialog();
        }

        private void AddSupActivitesBtn_Click(object sender, EventArgs e)
        {
            
            FrmAddSubActivities AddSub = new FrmAddSubActivities();
            AddSub.ShowDialog();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }

        private void FrmAllActivitesMange_Load(object sender, EventArgs e)
        {
            projectActivityBindingSource.DataSource = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);

            projectSubActivityBindingSource.DataSource = SubActivityCmd.GetAllSubActivities();
            ActivitiesGridView.MasterTemplate.ExpandAll();
        }

        private void ActivitiesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col2 = ActivitiesGridView.CurrentColumn.Index;

            if (col2 == 8)
            {
                
                FrmActivitiesEdit EditActi = new FrmActivitiesEdit();
                EditActi.xID = int.Parse(ActivitiesGridView.CurrentRow.Cells[0].Value.ToString());
                EditActi.ActivitiesNameTextBox.Text = ActivitiesGridView.CurrentRow.Cells[1].Value.ToString();
                EditActi.ActivitiesDescriptionTextBox.Text = ActivitiesGridView.CurrentRow.Cells[2].Value.ToString();
                EditActi.StartDateTimePicker.Text = ActivitiesGridView.CurrentRow.Cells[3].Value.ToString();
                EditActi.EndDateTimePicker.Text = ActivitiesGridView.CurrentRow.Cells[4].Value.ToString();
                EditActi.TotalCostTextBox.Text = ActivitiesGridView.CurrentRow.Cells[7].Value.ToString();
                EditActi.StatusDropDownList.Text = ActivitiesGridView.CurrentRow.Cells[5].Value.ToString();

                EditActi.ShowDialog();
                return;

            }

                        
            if (col2 == 9)
            {
                MessageBox.Show("delte");
                return;

            }


            var col = gridViewTemplate2.CurrentColumn.Index;
            if (col == 10)
            {
               
                FrmSubActivityEdit EditSubActi = new FrmSubActivityEdit();
                 
                EditSubActi.FillActivty();
                EditSubActi.SubXid = int.Parse(ActivitiesGridView.CurrentRow.Cells[0].Value.ToString());
                EditSubActi.SubActivitiesNameTextBox.Text = ActivitiesGridView.CurrentRow.Cells[1].Value.ToString();
                EditSubActi.SubActivitiesDescriptionTextBox.Text = ActivitiesGridView.CurrentRow.Cells[2].Value.ToString();
                EditSubActi.StartDateTimePicker.Text = ActivitiesGridView.CurrentRow.Cells[3].Value.ToString();
                EditSubActi.EndDateTimePicker.Text = ActivitiesGridView.CurrentRow.Cells[4].Value.ToString();
               
                EditSubActi.StatusDropDownList.Text = ActivitiesGridView.CurrentRow.Cells[5].Value.ToString();
               EditSubActi.ProgressEditor.Value = int.Parse(ActivitiesGridView.CurrentRow.Cells[6].Value.ToString());
                EditSubActi.TotalCostTextBox.Text = ActivitiesGridView.CurrentRow.Cells[7].Value.ToString();
                EditSubActi.ActivitiesColumnComboBox.Text = ActivitiesGridView.CurrentRow.Cells[9].Value.ToString();
                EditSubActi.ShowDialog();
                return;
            }


            if (col == 11)
            {
                MessageBox.Show("SubDelete");
            }
        }
    }
}

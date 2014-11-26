using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.ActivitiesForm
{
    public partial class FrmAllActivitesMange : Telerik.WinControls.UI.RadForm
    {
        public FrmAllActivitesMange()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        UcasProEntities db = new UcasProEntities();
        private void AdActivitesBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddActivities AddActivfrm = new FrmAddActivities();
            AddActivfrm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void AddSupActivitesBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAddSubActivities AddSub = new FrmAddSubActivities();
            AddSub.ShowDialog();
            Operation.EndOperation(this);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
          
        }
        private void TotalActivites()
        {

            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("TotalCost", "اجمالي الانشطة = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.ActivitiesGridView.SummaryRowsBottom.Clear();
            this.ActivitiesGridView.SummaryRowsBottom.Add(summaryRowItem);


            GridViewSummaryItem summaryItemFreight1 = new GridViewSummaryItem("SubTotalCost", "الاجمالي  = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem1 = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight1 });
            this.gridViewTemplate2.SummaryRowsBottom.Clear();
            this.gridViewTemplate2.SummaryRowsBottom.Add(summaryRowItem1);
            
            foreach (var item in ActivitiesGridView.Rows)
            {
                
            }
            ///
         
        }
        private void FrmAllActivitesMange_Load(object sender, EventArgs e)
        {
            projectActivityBindingSource.DataSource = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
            projectSubActivityBindingSource.DataSource = SubActivityCmd.GetAllSubActivities();
            //for (int i = 1; i <= ActivitiesGridView.Rows.Count; i++)
            //{
            //    ActivitiesGridView.Rows[i - 1].Cells["Num"].Value = i.ToString();
                
            //}


            //for (int i = 1; i <= gridViewTemplate2.Rows.Count; i++)
            //{
            //    gridViewTemplate2.Rows[i - 1].Cells["Num1"].Value = i.ToString();
            //}
            ActivitiesGridView.MasterTemplate.ExpandAll();
            TotalActivites();


            
            
        }

        
        private void ActivitiesGridView_CommandCellClick(object sender, EventArgs e)
        {

            var col2 = ActivitiesGridView.CurrentColumn.Index;

            if (col2 == 9)
            {

                this.Cursor = Cursors.WaitCursor;
                FrmActivitiesEdit EditActi = new FrmActivitiesEdit();
                EditActi.xID = int.Parse(ActivitiesGridView.CurrentRow.Cells[1].Value.ToString());
                EditActi.ActivitiesNameTextBox.Text = ActivitiesGridView.CurrentRow.Cells[2].Value.ToString();
                EditActi.ActivitiesDescriptionTextBox.Text = ActivitiesGridView.CurrentRow.Cells[3].Value.ToString();
                EditActi.StartDateTimePicker.Text = ActivitiesGridView.CurrentRow.Cells[4].Value.ToString();
                EditActi.EndDateTimePicker.Text = ActivitiesGridView.CurrentRow.Cells[5].Value.ToString();
                EditActi.TotalCostTextBox.Text = ActivitiesGridView.CurrentRow.Cells[8].Value.ToString();
                EditActi.StatusDropDownList.Text = ActivitiesGridView.CurrentRow.Cells[6].Value.ToString();

                EditActi.ShowDialog();
                this.Cursor = Cursors.Default;
                return;

            }

                        
            if (col2 == 10) 
            {
                this.Cursor = Cursors.WaitCursor;
               
                ActivityCmd.DeleteActivity(int.Parse(ActivitiesGridView.CurrentRow.Cells[0].Value.ToString()));
                this.Cursor = Cursors.Default;
                MessageBox.Show("تمت علمية الحذف");

                return;
                
            }


            var col = gridViewTemplate2.CurrentColumn.Index;
            if (col == 8)
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


            if (col == 9)
                
            {
                
                ProjectSubActivity tb = projectSubActivityBindingSource.Current as ProjectSubActivity;
                SubActivityCmd.DeleteSubActivity(tb.ID);
                MessageBox.Show("تمت علمية الحذف");
                return;
            }
        }

        private void ActivitiesGridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Font newFont = new Font("Arial", 12f, FontStyle.Bold);

            if (e.CellElement.ColumnInfo.Name == "ActivityName") 
            {
                e.CellElement.ForeColor = Color.DeepSkyBlue;
                e.CellElement.Font = newFont;
                
            }
           

           if (e.CellElement.ColumnInfo.Name == "ActivityDescription"){
               e.CellElement.ForeColor = Color.DeepSkyBlue;
               e.CellElement.Font = newFont;

           }


           if (e.CellElement.ColumnInfo.Name == "ActivityStartDate")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
               e.CellElement.Font = newFont;

           }

            //
           if (e.CellElement.ColumnInfo.Name == "ActivityEndDate")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
               e.CellElement.Font = newFont;

           }
            //
           if (e.CellElement.ColumnInfo.Name == "ActivityStatus")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
               e.CellElement.Font = newFont;

           }
            //
           if (e.CellElement.ColumnInfo.Name == "ActivityProgress")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
               e.CellElement.Font = newFont;

           }

           if (e.CellElement.ColumnInfo.Name == "ActivityProgress")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
               e.CellElement.Font = newFont;

           }
          
            
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmAllActivitesMange_Activated(object sender, EventArgs e)
        {
            //Operation.BeginOperation(this);

            //FrmAllActivitesMange_Load(sender, e);
            //Operation.EndOperation(this);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmAllActivitesMange_Load(sender, e);
            Operation.EndOperation(this);
        }
    }
}

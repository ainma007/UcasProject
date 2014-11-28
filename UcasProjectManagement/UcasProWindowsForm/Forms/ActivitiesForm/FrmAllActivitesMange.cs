using System;
using System.Drawing;
using System.Threading;
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




            //GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("ActivityTotalCost", "الاجمالي العام = {0}", GridAggregateFunction.Sum);
            //GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            //this.ActivitiesGridView.SummaryRowsBottom.Clear();
            //this.ActivitiesGridView.SummaryRowsBottom.Add(summaryRowItem);


            GridViewSummaryItem summaryItemFreight1 = new GridViewSummaryItem("SubTotalCost", "الاجمالي  = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem1 = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight1 });
            this.gridViewTemplate2.SummaryRowsBottom.Clear();
            this.gridViewTemplate2.SummaryRowsBottom.Add(summaryRowItem1);
          
            
          
            ///
         
        }

        private void Loadactivites()
            
        {
            
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";
               
            });
            Operation.BeginOperation(this);
            try
            {
                Application.DoEvents();
                projectActivityBindingSource.DataSource = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
                projectSubActivityBindingSource.DataSource = SubActivityCmd.GetAllSubActivities();
                ActivitiesGridView.MasterTemplate.ExpandAll();
                TotalActivites();
                Application.DoEvents();
            }
            catch (System.InvalidOperationException ex)
            {

                Application.DoEvents();
                projectActivityBindingSource.DataSource = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
                projectSubActivityBindingSource.DataSource = SubActivityCmd.GetAllSubActivities();
                ActivitiesGridView.MasterTemplate.ExpandAll();
                TotalActivites();
                Application.DoEvents();
            }

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = " ";
              
            });
        }
        private void FrmAllActivitesMange_Load(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //projectActivityBindingSource.DataSource = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
            //this.Cursor = Cursors.Default;
            //projectSubActivityBindingSource.DataSource = SubActivityCmd.GetAllSubActivities();
            //for (int i = 1; i <= ActivitiesGridView.Rows.Count; i++)
            //{
            //    ActivitiesGridView.Rows[i - 1].Cells["Num"].Value = i.ToString();

            //}


            //for (int i = 1; i <= gridViewTemplate2.Rows.Count; i++)
            //{
            //    gridViewTemplate2.Rows[i - 1].Cells["Num1"].Value = i.ToString();
            //}
          
            //this.Cursor = Cursors.Default;
            Loadactivites();
           
            
        }

        
        private void ActivitiesGridView_CommandCellClick(object sender, EventArgs e)
        {

            var col2 = ActivitiesGridView.CurrentColumn.Index;

            if (col2 == 9)
            {

               
                this.Cursor = Cursors.WaitCursor;
                FrmActivitiesEdit frm = new FrmActivitiesEdit();
                Ucas.Data.ProjectActivity DB = (Ucas.Data.ProjectActivity)ActivitiesGridView.CurrentRow.DataBoundItem;
                frm.TragetActivity = DB;
                frm.ShowDialog();
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

                FrmSubActivityEdit frm = new FrmSubActivityEdit();
                Ucas.Data.ProjectSubActivity DB = (Ucas.Data.ProjectSubActivity)ActivitiesGridView.CurrentRow.DataBoundItem;
                frm.TragetSUBActivity = DB;
                frm.FillActivty();
                frm.ShowDialog();
                
               
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
          //  Font newFont = new Font("Arial", 12f, FontStyle.Bold);

            if (e.CellElement.ColumnInfo.Name == "ActivityName") 
            {
                e.CellElement.ForeColor = Color.DeepSkyBlue;
           //     e.CellElement.Font = newFont;
                
            }
           

           if (e.CellElement.ColumnInfo.Name == "ActivityDescription"){
               e.CellElement.ForeColor = Color.DeepSkyBlue;
           //    e.CellElement.Font = newFont;

           }


           if (e.CellElement.ColumnInfo.Name == "ActivityStartDate")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
           //    e.CellElement.Font = newFont;

           }

            //
           if (e.CellElement.ColumnInfo.Name == "ActivityEndDate")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
           //    e.CellElement.Font = newFont;

           }
            //
           if (e.CellElement.ColumnInfo.Name == "ActivityStatus")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
            //   e.CellElement.Font = newFont;

           }
            //
           if (e.CellElement.ColumnInfo.Name == "ActivityProgress")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
             //  e.CellElement.Font = newFont;

           }

           if (e.CellElement.ColumnInfo.Name == "ActivityProgress")
           {
               e.CellElement.ForeColor = Color.DeepSkyBlue;
             //  e.CellElement.Font = newFont;

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
            this.Cursor = Cursors.WaitCursor;
            FrmAllActivitesMange_Load(sender, e);
            this.Cursor = Cursors.Default;
        }

        private void radStatusStrip1_StatusBarClick(object sender, RadStatusBarClickEventArgs args)
        {

        }
    }
}

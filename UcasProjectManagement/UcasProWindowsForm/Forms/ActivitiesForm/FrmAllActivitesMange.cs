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

        
        private void TotalActivites()
        {


            GridViewSummaryItem summaryItemFreight1 = new GridViewSummaryItem("SubTotalCost", "الاجمالي={0}"+InformationsClass.Coin+"", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem1 = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight1 });
            this.gridViewTemplate2.SummaryRowsBottom.Clear();
            this.gridViewTemplate2.SummaryRowsBottom.Add(summaryRowItem1);
          
            
          
            ///
            GridViewSummaryItem summaryItemFreight = new GridViewSummaryItem("ActivityTotalCost", "الاجمالي العام={0}" + InformationsClass.Coin + "", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemFreight });
            this.ActivitiesGridView.SummaryRowsBottom.Clear();
            this.ActivitiesGridView.SummaryRowsBottom.Add(summaryRowItem);
        }

        private void Loadactivites()
            
        {
            
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "يرجى الانتظار ... ";
               
            });
            Operation.BeginOperation(this);
           
                Application.DoEvents();
                var q = ActivityCmd.GetAllActivitiesByProjectID(InformationsClass.ProjID);
                var q1 = SubActivityCmd.GetAllSubActivitiesByProjectID(InformationsClass.ProjID);
                                                     
                Application.DoEvents();
           
           

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                projectActivityBindingSource.DataSource = q;
                projectSubActivityBindingSource.DataSource = q1;
                ActivitiesGridView.MasterTemplate.ExpandAll();
                TotalActivites();
                toolStripStatusLabel1.Text = " ";
              
            });
        }
        private void FrmAllActivitesMange_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(Loadactivites);
            th.Start();
           
           
            
        }

        
        private void ActivitiesGridView_CommandCellClick(object sender, EventArgs e)
        {

            var col2 = ActivitiesGridView.CurrentColumn.Index;

            if (col2 == 9)
            {


                Operation.BeginOperation(this);
               

                FrmActivitiesEdit frm = new FrmActivitiesEdit();
                Ucas.Data.ProjectActivity DB = (Ucas.Data.ProjectActivity)ActivitiesGridView.CurrentRow.DataBoundItem;
                frm.TragetActivity = DB;
                frm.ShowDialog();
                Operation.EndOperation(this);
                return;

            }

                        
            if (col2 == 10) 
            {
                
                if (RadMessageBox.Show(this, OperationX.DeletedMessage, "حذف سجل", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                if(    ActivityCmd.DeleteActivity(int.Parse(ActivitiesGridView.CurrentRow.Cells[1].Value.ToString())))
                {

                    Operation.EndOperation(this);
                    Operation.ShowToustOk("تمت عملية الحذف", this);

                    return;
                }

                else
                {
                    Operation.EndOperation(this);

                    RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
                    
                }
                
                
            }


            var col = gridViewTemplate2.CurrentColumn.Index;
            if (col == 8)
            {
                Operation.BeginOperation(this);
               

                FrmSubActivityEdit frm = new FrmSubActivityEdit();
                Ucas.Data.ProjectSubActivity DB = (Ucas.Data.ProjectSubActivity)ActivitiesGridView.CurrentRow.DataBoundItem;
                frm.TragetSUBActivity = DB;
                frm.ShowDialog();
                Operation.EndOperation(this);
               
                return;
            }


            if (col == 9)
                
            {
                if (RadMessageBox.Show(this, OperationX.DeletedMessage, "حذف سجل", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    ProjectSubActivity tb = projectSubActivityBindingSource.Current as ProjectSubActivity;
                    if (SubActivityCmd.DeleteSubActivity(tb.ID))
                    {
                        Operation.EndOperation(this);
                        FrmAllActivitesMange_Load(sender, e);
                        Operation.ShowToustOk("تمت عملية الحذف", this);
                        return;
                    }
                    else
                    {
                        RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                    }
                }
               
                
            }
        }

        private void ActivitiesGridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Font newFont = new Font("Times New Roman", 12f, FontStyle.Bold);

            if (e.CellElement.ColumnInfo.Name == "ActivityName")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }


            if (e.CellElement.ColumnInfo.Name == "ActivityDescription")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }


            if (e.CellElement.ColumnInfo.Name == "ActivityStartDate")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }

            //
            if (e.CellElement.ColumnInfo.Name == "ActivityEndDate")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }
            //
            if (e.CellElement.ColumnInfo.Name == "ActivityStatus")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }
            //
            if (e.CellElement.ColumnInfo.Name == "ActivityProgress")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }
             if (e.CellElement.ColumnInfo.Name == "ActivityStatus"){
                string title = e.CellElement.RowInfo.Cells[6].Value.ToString();
                if (title == "غير فعال")
                {

                    e.CellElement.ForeColor = Color.Red;
                    e.CellElement.Font = newFont;
                }
                else
                {
                    e.CellElement.ForeColor = Color.DarkSlateBlue;
                    e.CellElement.Font = newFont;
                }
        }

            if (e.CellElement.ColumnInfo.Name == "ActivityTotalCost")
            {
                e.CellElement.ForeColor = Color.DarkSlateBlue;
                e.CellElement.Font = newFont;

            }
        }

       
        private void FrmAllActivitesMange_Activated(object sender, EventArgs e)
        {
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            
            FrmAllActivitesMange_Load(sender, e);
          
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            this.ActivitiesGridView.PrintPreview();
        }

     
    }
}

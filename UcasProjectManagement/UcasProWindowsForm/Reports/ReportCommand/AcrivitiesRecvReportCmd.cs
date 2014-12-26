using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
    public  class AcrivitiesRecvReportCmd
    {


          public AcrivitiesRecvReportCmd() { }

         public void GetRptAcrivitiesByProjectId(int ProjID)
       {
           var q = SubActivityCmd.GetAllSubActivitiesByProjectID(ProjID);
           ReportDataSource rs = new ReportDataSource();
           List<ActivitesRecvtReportObj> ls = new List<ActivitesRecvtReportObj>();
          
           foreach (var item in q)
           {
             
               ls.Add(new ActivitesRecvtReportObj()
               {
               
                  ProjectName=item.ProjectProfile.ProjectName,
                  Coin=item.ProjectProfile.Coin,
                  ActivitesName=item.ProjectActivity.ActivityName,
                  ActivitesDec=item.ProjectActivity.Description,
                  StartDate=item.ProjectActivity.StartDate.Value,
                  Enddate=item.ProjectActivity.EndDate.Value,
                  ActivitesCost=item.ProjectActivity.TotalCost.Value,
                  Progress=item.ProjectActivity.Progress.Value,
                  Stauts=item.ProjectActivity.Status,
                  ////
                  SubActivitesName= item.SubActivityName,
                  SubActivitesDec=item.Description,
                  SubStartDate=item.Startdate.Value,
                  SubEnddate=item.enddate.Value,
                  SubCost=item.TotalCost.Value,
                  SubProgress=item.Progress.Value,
                  SubStauts=item.Status,
                 AllTotalActivites = ActivityCmd.GetTotalActivity(InformationsClass.ProjID),
                 TotalExpensess= ProjectExpensesCmd.GetTotalExpensesBySubActivity(item.ID)
                   
                  
               }); 
           }
           rs.Name = "ActivitiesDataSet";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptActivties.rdlc";
           frm.ShowDialog();




    }
}
}
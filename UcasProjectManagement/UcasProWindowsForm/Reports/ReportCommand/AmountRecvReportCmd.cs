using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
     public   class AmountRecvReportCmd
    {

         public AmountRecvReportCmd() { }

         public void GetRptAmountRecvByProjectId(int ProjID)
       {
           var q = AmountsReceivedsCmd.GetAllAmountsReceivedBypro(ProjID);
           ReportDataSource rs = new ReportDataSource();
           List<AmountRecvtReportObj> ls = new List<AmountRecvtReportObj>();
          
           foreach (var item in q)
           {
             
               ls.Add(new AmountRecvtReportObj()
               {
               
                 ProjectName=item.ProjectProfile.ProjectName,
                  Coin=item.ProjectProfile.Coin,
                  DonerName=item.TheDonorsProject.TheDonor.Name,
                  Date=item.Date.Value,
                  Cost=item.Cost.Value,
                  
               }); 
           }
           rs.Name = "AmountsReceivedDataSet";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptAmountsReceived.rdlc";
           frm.ShowDialog();


       }

         public void ShowReportByGrid(List<AmountRecvtReportObj> ls)
         {
             ReportDataSource rs = new ReportDataSource();
             rs.Name = "AmountsReceivedDataSet";
             rs.Value = ls;
             frmReportViewer frm = new frmReportViewer();
             frm.reportViewer1.LocalReport.DataSources.Clear();
             frm.reportViewer1.LocalReport.DataSources.Add(rs);
             frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptAmountsReceived.rdlc";
             frm.ShowDialog();
         }

    }
}

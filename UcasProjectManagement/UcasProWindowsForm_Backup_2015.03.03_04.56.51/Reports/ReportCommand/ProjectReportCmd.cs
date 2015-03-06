using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.MainForm;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
     public  class ProjectReportCmd
    {

         public void GetByProjectId(int ProjID)
         {
             var q1 = ProjectProfileCmd.GetProjectData(ProjID);
             var q = TheDonorsProjectCmd.GetAllDonorsByproID(ProjID);
             ReportDataSource rs = new ReportDataSource();
             List<ProjectReportObj> ls = new List<ProjectReportObj>();
             FrmMainUserPro Mainfrm = new FrmMainUserPro();
             int counter = 0;

            
             foreach (var item in q)
             {
                 counter++;
                 ls.Add(new ProjectReportObj()
                 {
                     ////
                     DonerID=counter,
                     DonorsName=item.TheDonor.Name,
                     Cost=item.TotalCost.Value,
                     ProjectName=item.ProjectProfile.ProjectName,
                     ProjectDescription=item.ProjectProfile.ProjectDescription,
                     progress=item.ProjectProfile.progress.Value,
                     TotalCost=item.ProjectProfile.TotalCost.Value,
                     StartDate=item.ProjectProfile.StartDate.Value,
                     EndDate=item.ProjectProfile.EndDate.Value,
                     Coin=item.ProjectProfile.Coin,
                     TotalExpenses=ProjectExpensesCmd.GetTotalExpensesByProject(ProjID),
                     TotalSalay=SalariesCmd.GetTotalSalaryByProject(ProjID),
                     AmountRecv=AmountsReceivedsCmd.GetTotalAmountsByProject(ProjID),
                     
                 });
             }
             rs.Name = "ProjectDataSet";
             rs.Value = ls;
             frmReportViewer frm = new frmReportViewer();
             frm.reportViewer1.LocalReport.DataSources.Clear();
             frm.reportViewer1.LocalReport.DataSources.Add(rs);
             frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptProject.rdlc";
             frm.ShowDialog();


         }


    }
}

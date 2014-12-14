using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using UcasProWindowsForm.Reports.ReportObj;
using UcasProWindowsForm.Reports;
using Ucas.Data.CommandClass;


namespace UcasProWindowsForm.Reports.ReportCommand
{
    class SalaryReportCmd
    {
        public SalaryReportCmd() { }

       public void GetByProjectId(int ProjID)
       {
           var q = SalariesCmd.GetSalaryBySelectedprotID(ProjID);
           ReportDataSource rs = new ReportDataSource();
           List<SalaryReportObj> ls = new List<SalaryReportObj>();
           int counter = 0;
           foreach (var item in q)
           {
               counter++;
               ls.Add(new SalaryReportObj()
               {
                   ProjectName = item.ProjectProfile.ProjectName,
                   SalarysID = counter ,
                   EmployeeName = item.Contract.Employee.EmployeeName,
                   SalaryAmount = item.Amount.Value,
                   SalaryIssueDate = item.IssueDate.Value,
                   SalaryForMonth = item.Formonth.Value,
                   coin=item.ProjectProfile.Coin,
                   EmployeejobNumber=item.Contract.Employee.EmployeejobNumber
                  
               }); 
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptSalaryGroupby.rdlc";
           frm.ShowDialog();


       }
       public void ShowReport(List<SalaryReportObj> ls)
       {
           ReportDataSource rs = new ReportDataSource();
           rs.Name = "DataSet1";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptSalaryGroupby.rdlc";
           frm.ShowDialog();
       }
    }
}

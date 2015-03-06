using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
    public  class ContractReportCmd
    {
        public ContractReportCmd() { }

       public void GetRptContractByProjectId(int ProjID)
       {
           var q = ContractCmd.GetAllContractsByproID(ProjID);
           ReportDataSource rs = new ReportDataSource();
           List<ContractReportObj> ls = new List<ContractReportObj>();
           int counter = 0;
           foreach (var item in q)
           {
               counter++;
               ls.Add(new ContractReportObj()
               {
                 ContractID=counter,
                 ProjectName=item.ProjectProfile.ProjectName,
                 EmployeeName=item.Employee.EmployeeName,
                 EmployeeJobNumber=item.Employee.EmployeejobNumber,
                 StartDate=item.StartDate.Value,
                 EndDate=item.EndDate.Value,
                 MonthlySalary =item.SelaryAmount.Value,
                 TotalSalary=item.TotalSalary.Value,
                 Coin=item.ProjectProfile.Coin,
                 
                  
               }); 
           }
           rs.Name = "ContractDataSet";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptContract.rdlc";
           frm.ShowDialog();


       }

    }
}

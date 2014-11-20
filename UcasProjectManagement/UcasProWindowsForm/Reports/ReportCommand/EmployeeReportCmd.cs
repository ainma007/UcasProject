using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
    public class EmployeeReportCmd
    {
        public EmployeeReportCmd() { }

       public void GetAllEmployee()
       {
           var q = EmployeeCmd.GetAll();
           ReportDataSource rs = new ReportDataSource();
           List<EmployeeReportObj> ls = new List<EmployeeReportObj>();
           int counter = 0;
           foreach (var item in q)
           {
               counter++;
               ls.Add(new EmployeeReportObj()
               {
                   EmoloyeeID = counter,
                   employeeName = item.EmployeeName ,
                   EmployeeGender = item.EmployeeGender,
                   EmployeejobNumber = item.EmployeejobNumber,
                   EmployeeNationalNumber = item.EmployeeNationalNumber,
                   PhoneNumber = item.PhoneNumber,
                   Mobilenumber=item.Mobilenumber,
                   Email=item.Email,
                  
               }); 
           }
           rs.Name = "EmplyeeDataSet";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptEmolyee.rdlc";
           frm.ShowDialog();


       }
    }
}

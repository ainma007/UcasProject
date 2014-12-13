using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
     public    class DonorsReportCmd
    {
         public DonorsReportCmd() { }

        public void GetAllDonor()
        {
            var q = TheDonorCmd.GetAllDonors();
            ReportDataSource rs = new ReportDataSource();
            List<DonaorReportObj> ls = new List<DonaorReportObj>();
            int counter = 0;
            foreach (var item in q)
            {
                counter++;
                ls.Add(new DonaorReportObj()
                {
                    DonorID = counter,
                    DonorName = item.Name,
                    DonorAgentname = item.agentName,
                    DonorFaxnumber = item.Fax,
                    DonorAddress = item.Adderss,
                    DonorPhoneNumber = item.PhoneNumber,
                    DonorEmail = item.Email


                });
            }
            rs.Name = "DonorDataSet";
            rs.Value = ls;
            frmReportViewer frm = new frmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptDonor.rdlc";
            frm.ShowDialog();

        }
        public void ShowEmpReportByGrid(List<DonaorReportObj> ls)
        {
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DonorDataSet";
            rs.Value = ls;
            frmReportViewer frm = new frmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptDonor.rdlc";
            frm.ShowDialog();
        }
    }
}

using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Reports.ReportObj;

namespace UcasProWindowsForm.Reports.ReportCommand
{
    public class SupplierReportCmd
    {
        public SupplierReportCmd() { }

        public void GetAllSupplier()
        {
            var q = SuppliersCmd.GetAll();
            ReportDataSource rs = new ReportDataSource();
            List<SupplierReportObj> ls = new List<SupplierReportObj>();
            int counter = 0;
            foreach (var item in q)
            {
                counter++;
                ls.Add(new SupplierReportObj()
                {
                    SupplierID = counter,
                    SupplierName = item.Name,
                    SuppliersNatural = item.SuppliersNatural,
                    Faxnumber = item.Fax,
                    Address = item.Adderss,
                    PhoneNumber = item.PhoneNumber,
                    Email = item.Email


                });
            }
            rs.Name = "SupplierDataSet";
            rs.Value = ls;
            frmReportViewer frm = new frmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptSupplier.rdlc";
            frm.ShowDialog();

        }
        public void ShowSuppReportByGrid(List<SupplierReportObj> ls)
        {
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "SupplierDataSet";
            rs.Value = ls;
            frmReportViewer frm = new frmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.rptSupplier.rdlc";
            frm.ShowDialog();
        }
    }
}
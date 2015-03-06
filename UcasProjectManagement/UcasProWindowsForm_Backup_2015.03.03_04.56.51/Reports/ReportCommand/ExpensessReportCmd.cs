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
   public class ExpensessReportCmd
    {
       public ExpensessReportCmd() { }

       public void GetByProjectId(int ProjID)
       {
           var q = ProjectExpensesCmd.GetAllExpensesByProject(ProjID);
           ReportDataSource rs = new ReportDataSource();
           List<ExpensessReportObj> ls = new List<ExpensessReportObj>();
           int counter = 0;
           foreach (var item in q)
           {
               counter++;
               ls.Add(new ExpensessReportObj()
               {
                   ProjectName = item.ProjectProfile.ProjectName,
                   ExpensessID = counter ,
                   ExpensessName = item.ExpensesName,
                   ExpenssesCost = item.RequiarAmount.Value,
                   DateOfs = item.DateofProcess.Value,
                   Bill_SerialNumber = item.BillNumber,
                   CashingNumber = item.CashingNumber,
                   SubActivityName = item.ProjectSubActivity.SubActivityName,
                   coin=item.ProjectProfile.Coin,
                   SupplierName=item.Supplier.Name
               }); 
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.RptExpensesss.rdlc";
           frm.ShowDialog();


       }


       public void ShowReportByGrid(List<ExpensessReportObj> ls)
       {
           ReportDataSource rs = new ReportDataSource();
           rs.Name = "DataSet1";
           rs.Value = ls;
           frmReportViewer frm = new frmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.RptExpensesss.rdlc";
           frm.ShowDialog();
       }
    }
}

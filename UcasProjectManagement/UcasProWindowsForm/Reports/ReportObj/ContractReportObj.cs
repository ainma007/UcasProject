using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UcasProWindowsForm.Reports.ReportObj
{
   public class ContractReportObj
    {

        public int ContractID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeJobNumber { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public double TotalSalary { get; set; }
        public double MonthlySalary { get; set; }
        public string ProjectName { get; set; }
        public string Coin { get; set; }

    }
}

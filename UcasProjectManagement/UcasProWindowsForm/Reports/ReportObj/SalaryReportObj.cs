using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UcasProWindowsForm.Reports.ReportObj
{
    public  class SalaryReportObj
    {
        public int SalarysID { get; set; }
        public string EmployeeName { get; set; }
        public double SalaryAmount { get; set; }
        public DateTime SalaryIssueDate { get; set; }
        public DateTime SalaryForMonth { get; set; }
        public string ProjectName { get; set; }
        public string coin { get; set; }
    } 
}

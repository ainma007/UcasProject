using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UcasProWindowsForm.Reports.ReportObj
{
   public class ExpensessReportObj 
    {
        public int ExpensessID { get; set; }
        public string  ExpensessName { get; set; }
        public double ExpenssesCost { get; set; }
        public string  Bill_SerialNumber { get; set; }
        public string  CashingNumber { get; set; }
        public string  SubActivityName { get; set; }
        public string  ActivityName { get; set; }
        public string  ProjectName { get; set; }
        public DateTime   DateOfs { get; set; }
        public string  coin { get; set; }

    }
}

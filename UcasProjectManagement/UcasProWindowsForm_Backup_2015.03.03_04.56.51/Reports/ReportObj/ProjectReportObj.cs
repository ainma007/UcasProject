using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UcasProWindowsForm.Reports.ReportObj
{
   public   class ProjectReportObj
    {

        public int ProjectId { get; set; }
        public  string ProjectName { get; set; }
        public  string ProjectDescription { get; set; }
        public DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
        public  string Status { get; set; }
        public  double progress { get; set; }
        public  double TotalCost { get; set; }
        public  string Coin { get; set; }

       /////Acount

        public double AmountRecv { get; set; }
        public double TotalExpenses { get; set; }
        public double TotalSalay { get; set; }
        public double Remaining { get; set; }

       /////Donores
       public int DonerID { get; set; }
       public string DonorsName { get; set; }
        public double Cost { get; set; }    

       
    }
}

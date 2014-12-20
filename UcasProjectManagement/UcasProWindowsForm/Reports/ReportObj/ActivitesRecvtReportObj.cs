using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcasProWindowsForm.Reports.ReportObj
{
   public class ActivitesRecvtReportObj
    {

       public string ProjectName { get; set; }
       public string Coin { get; set; }
       public string ActivitesName { get; set; }
       public string ActivitesDec { get; set; }
       public DateTime StartDate { get; set; }
       public DateTime Enddate { get; set; }
       public double ActivitesCost { get; set; }
       public double Progress { get; set; }
       public string Stauts{get;set;}
       public double AllTotalActivites { get; set; }

       //Sub

       public string SubActivitesName { get; set; }
       public string SubActivitesDec { get; set; }
       public DateTime SubStartDate { get; set; }
       public DateTime SubEnddate { get; set; }
       public double SubCost { get; set; }
       public double SubProgress { get; set; }
       public string SubStauts{get;set;}

       }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.Special_Classes
{
    public class AlertsClass
    {
        static UcasProEntities db = new UcasProEntities();


        #region "  ^^^ Projects Alerts       "
        public static List<ProjectProfile> AlertAllProjectsEnded()
        {
            DateTime CheckerDate = DateTime.Now.AddDays(3);

            db = new UcasProEntities();
            var LST = (from p in db.ProjectProfiles
                       orderby p.StartDate ascending
                       where p.EndDate == CheckerDate 
                       select p).ToList();
            return LST;
        }
        #endregion



        #region " ^^^ Employees Contracts Alerts    "

        public static List<Contract> AlertAllContractsEnded()
        {
            DateTime CheckerDate = DateTime.Now.AddDays(3);
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LstExpiers = ( from c in  db.Contracts.ToList()
                             orderby c.StartDate ascending 
                      //       where c.EndDate == CheckerDate.ToShortDateString () 
                             select c).ToList ();
          return LstExpiers;
        }

        #endregion

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
  public  class AmountsReceivedsCmd
    {

        static UcasProEntities db = new UcasProEntities();
        public static bool NewAmountsReceived(AmountsReceived tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.AmountsReceiveds.Add(tb);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditAmountsReceived(AmountsReceived tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.AmountsReceiveds.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.TheFinancerProjectsID = tb.TheFinancerProjectsID;
                q.Date = tb.Date;
                q.Cost = tb.Cost;


                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteAmountsReceived(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.AmountsReceiveds.Where(p => p.ID == ID).SingleOrDefault();
                db.AmountsReceiveds.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<AmountsReceived> GetAllAmountsReceived()
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.AmountsReceiveds.ToList();
        }

        public static List<AmountsReceived> GetAllAmountsReceivedByTheFinancierPrjectID(int F_PID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = ( from f in db.AmountsReceiveds 
                        orderby f.Date ascending 
                            where f.TheFinancerProjectsID == F_PID 
                            select f).ToList();
            return LST;
        }
        public static IEnumerable GetAllAmountsReceivedBypro(int ProId)
        {
            db = new UcasProEntities();
            var q = (from i in db.AmountsReceiveds
                     join Dpro in db.TheDonorsProjects on i.TheFinancerProjectsID equals Dpro.ID
                     join donrs in db.TheDonors on Dpro.DonorsID equals donrs.ID
                     where i.ProjectProfile_ID == ProId




                     select new { i.ID, donrs.Name, i.Date, i.Cost}).ToList();
            return q;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public class TheDonorsCmd
    {
        static UcasProEntities db = new UcasProEntities();

        public static List<TheDonors> GetAllDonors()
        {
            db = new UcasProEntities();
            var Lst = (from f in db.TheDonors1 orderby f.Name ascending select f).ToList();
            return Lst;
        }
        public static bool AddDonor(TheDonors tb)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            db.TheDonors1.Add(tb);
            db.SaveChanges();
            return true;
        }


        public static bool EditDonor(TheDonors tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.TheDonors1.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.Name = tb.Name;
                q.agentName = tb.agentName;
                q.PhoneNumber = tb.PhoneNumber;
                q.Fax = tb.Fax;
                q.Email = tb.Email;
                q.Adderss = tb.Adderss;


                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteDonor(int xid)
        {
            try
            {
                db = new UcasProEntities();
                TheDonors tb = new TheDonors();
                tb = db.TheDonors1.Where(f => f.ID == xid).Single();

                if (tb.ID != 0)
                {
                    db.TheDonors1.Remove(tb);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}

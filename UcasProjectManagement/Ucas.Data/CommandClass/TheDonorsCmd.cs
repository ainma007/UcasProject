using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public class TheDonorCmd
    {
        static UcasProEntities db = new UcasProEntities();

        public static List<TheDonor> GetAllDonors()
        {
            db = new UcasProEntities();
            var Lst = (from f in db.TheDonors orderby f.Name ascending select f).ToList();
            return Lst;
        }
        public static bool AddDonor(TheDonor tb)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            db.TheDonors.Add(tb);
            db.SaveChanges();
            return true;
        }


        public static bool EditDonor(TheDonor tb)
        {
           
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.TheDonors.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.Name = tb.Name;
                q.agentName = tb.agentName;
                q.PhoneNumber = tb.PhoneNumber;
                q.Fax = tb.Fax;
                q.Email = tb.Email;
                q.Adderss = tb.Adderss;


                db.SaveChanges();
                return true;

            
           
        }

        public static bool DeleteDonor(int xid)
        {
            
                db = new UcasProEntities();
                TheDonor tb = new TheDonor();
                tb = db.TheDonors.Where(f => f.ID == xid).Single();

                if (tb.ID != 0)
                {
                    db.TheDonors.Remove(tb);
                    db.SaveChanges();
                    return true;
                }
                return false;
            
           
        }

    }
}

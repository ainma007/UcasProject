using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
  public  class TheDonorsProjectCmd
    {
        static UcasProEntities db = new UcasProEntities();

        public static List<TheDonorsProject> GetAllDonors()
        {
            db = new UcasProEntities();
            return db.TheDonorsProjects.ToList();
        }



        public static IEnumerable GetAllDonorsBypro(int ProId)
        {
            db = new UcasProEntities();
            var q = (from i in db.TheDonorsProjects
                     join pro in db.TheDonors on i.DonorsID equals pro.ID
                     where i.ProjectID == ProId
                   



                     select new { i.ID, pro.Name,i.TotalCost }).ToList();
            return q;

        }
        #region " { Get Current Project's Donors Only } "
        public static List<TheDonorsProject> GetAllDonorsOfSelectedProject(int ProjId)
        {
            try
            {
                if (ProjId != 0)
                {
                    var CurrentFinanciers = (from Pro in db.TheDonorsProjects
                                             where Pro.ProjectID == ProjId
                                             select Pro).ToList();
                    return CurrentFinanciers;
                }
                return null;

            }
            catch (Exception)
            {

                return null;
            }
        }
        # endregion

        public static bool AddTheTheDonorsProject(TheDonorsProject tb)
        {
            db = new UcasProEntities();
            db.TheDonorsProjects.Add(tb);
            db.SaveChanges();
            return true;
        }

        public static bool EditTheDonorsProject(TheDonorsProject tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.TheDonorsProjects.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.DonorsID = tb.DonorsID;
                q.TotalCost = tb.TotalCost;
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool DeleteDonorsProject(int xid)
        {
            try
            {
                db = new UcasProEntities();
                TheDonorsProject tb = new TheDonorsProject();
                tb = db.TheDonorsProjects.Where(f => f.ID == xid).Single();
                if (tb.ID != 0)
                {
                    db.TheDonorsProjects.Remove(tb);
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
        public static IEnumerable GetAllDonorsForAmountsBypro(int ProId)
        {
            db = new UcasProEntities();
            var q = (from i in db.TheDonorsProjects
                     join donrs in db.TheDonors on i.DonorsID equals donrs.ID
                     where i.ProjectID == ProId
                     select new { i.ID, donrs.Name }).ToList();
            return q;

        }
    }


}

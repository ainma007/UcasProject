using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
  public  class TheDonorsProjectCmd
    {
        static UcasProEntities db = new UcasProEntities();
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
    }
}

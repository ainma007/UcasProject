using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        public static List<TheDonorsProject> GetAllDonorsByproID(int ProID)
        {
            db = new UcasProEntities();

            var LST = (from c in db.TheDonorsProjects
                       where c.ProjectID == ProID
                       select c).ToList();
            return LST;


        }
        public static bool AddTheTheDonorsProject(TheDonorsProject tb)
        {
            try
            {
                db = new UcasProEntities();
                db.TheDonorsProjects.Add(tb);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                Xprema.XpremaException e = new Xprema.XpremaException();
                e.CodeNumber = 6;
                e.OtherDescription = ex.InnerException.InnerException.Message;
                File.WriteAllText("t.txt", ex.InnerException.InnerException.Message);
                e.UserDescription = "Error in Save Changed";
                if (ex.InnerException.InnerException.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TheDonorsProjects_1'. Cannot insert duplicate key in object 'dbo.TheDonorsProjects'. The duplicate key value is (3, 4)"))
                {
                    e.UserDescriptionArabic = "الممول مضاف مسبقا للمشروع";

                }
                else
                    e.UserDescriptionArabic = e.OtherDescription;//"خطاء في اضافة البيانات";

                throw e;
            }
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
            catch (Exception ex)
            {

                Xprema.XpremaException e = new Xprema.XpremaException();
                e.CodeNumber = 6;
                e.OtherDescription = ex.InnerException.InnerException.Message;
                File.WriteAllText("t.txt", ex.InnerException.InnerException.Message);
                e.UserDescription = "Error in Save Changed";
                if (ex.InnerException.InnerException.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TheDonorsProjects_1'. Cannot insert duplicate key in object 'dbo.TheDonorsProjects'. The duplicate key value is (3, 4)"))
                {
                    e.UserDescriptionArabic = "الممول مضاف مسبقا للمشروع";

                }
                else
                    e.UserDescriptionArabic = e.OtherDescription;//"خطاء في اضافة البيانات";

                throw e;
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

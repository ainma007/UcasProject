using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public class ActivityCmd
    {


        static UcasProEntities db = new UcasProEntities();
        public static bool NewActivity(ProjectActivity Actv)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.ProjectActivities.Add(Actv);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                Xprema.XpremaException e = new Xprema.XpremaException();
                e.CodeNumber = 6;
                e.OtherDescription = ex.InnerException.InnerException.Message;
                e.UserDescription = "Error in Save Changed";
                e.UserDescriptionArabic = "خطاء في اضافة البيانات";
                throw e;
            }
        }
        public static bool EditActivity(ProjectActivity Actv)
        {


            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectActivities.Where(p => p.ID == Actv.ID).SingleOrDefault();
                q.ActivityName = Actv.ActivityName;
                q.Description = Actv.Description;
                q.StartDate = Actv.StartDate;
                q.EndDate = Actv.EndDate;
                q.TotalCost = Actv.TotalCost;
                q.Status = Actv.Status;
          

                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                Xprema.XpremaException e = new Xprema.XpremaException();
                e.CodeNumber = 6;
                e.OtherDescription = ex.InnerException.InnerException.Message;
                e.UserDescription = "Error in Save Changed";
                e.UserDescriptionArabic = "خطاء في حفظ البيانات";
                throw e;
            }
        }

        public static bool DeleteActivity(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectActivities.Where(p => p.ID == ID).SingleOrDefault();
                db.ProjectActivities.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<ProjectActivity> GetAllActivitiesByProjectID(int ProID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = (from p in db.ProjectActivities
                       orderby p.StartDate ascending 
                       where p.ProjectProfile_ID == ProID
                       select p).ToList();
            return LST; ;
        }

        public static List<ProjectActivity> GetAll() { return  db.ProjectActivities.ToList(); }

    }

}

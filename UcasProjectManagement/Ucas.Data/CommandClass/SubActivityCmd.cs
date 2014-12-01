using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
  public  class SubActivityCmd
    {
        static UcasProEntities db = new UcasProEntities();
        public static bool NewSubActivity(ProjectSubActivity SActv)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.ProjectSubActivities.Add(SActv);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                Xprema.XpremaException e = new Xprema.XpremaException();
                e.CodeNumber = 6;
                e.OtherDescription = ex.InnerException.InnerException.Message;
                e.UserDescription = "Error in Add";
                e.UserDescriptionArabic = "خطاء في اضافة البيانات";
                throw e;
            }
        }
        public static bool EditSubActivity(ProjectSubActivity SActv)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectSubActivities.Where(p => p.ID == SActv.ID).SingleOrDefault();
                q.ProjectActivity_ID = SActv.ProjectActivity_ID;
                q.SubActivityName = SActv.SubActivityName;
                q.Description = SActv.Description;
                q.Startdate = SActv.Startdate;
                q.enddate = SActv.enddate;
                q.TotalCost = SActv.TotalCost;
                q.Status = SActv.Status;
                q.Progress = SActv.Progress;

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
       

        public static bool DeleteSubActivity(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectSubActivities.Where(p => p.ID == ID).SingleOrDefault();
                db.ProjectSubActivities.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


     
        public static List<ProjectSubActivity> GetAllSubActivitiesByActivityID(int ActID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
          var LST = (from A in  db.ProjectSubActivities 
                     orderby A.Startdate ascending 
                     where A.ProjectActivity_ID== ActID
                     select A).ToList();
          return LST;
         
        }

        public static List<ProjectSubActivity> GetAllSubActivitiesByProjectID(int ProID)
        {
            db = new UcasProEntities();
         var LST = (from A in db.ProjectSubActivities
         where A.ProjectProfile_ID == ProID
         select A).ToList();
         return LST;

        }
        public static List<ProjectSubActivity> GetAllSubActivities()
        {
            db = new UcasProEntities();
            return db.ProjectSubActivities.ToList();
        }
    }
}

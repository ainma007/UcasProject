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

                return false;
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


                return false;
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

    }
}

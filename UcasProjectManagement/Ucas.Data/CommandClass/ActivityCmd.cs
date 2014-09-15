﻿using System;
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

                return false;
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
                q.ProjectProfile_ID = Actv.ProjectProfile_ID;
                q.ActivityName = Actv.ActivityName;
                q.Description = Actv.Description;
                q.StartDate = Actv.StartDate;
                q.EndDate = Actv.EndDate;
                q.TotalCost = Actv.TotalCost;
                q.Status = Actv.Status;
                q.Progress = Actv.Progress;

                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
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

        public static List<ProjectActivity> GetAll()
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.ProjectActivities.ToList();
        }
    }

}

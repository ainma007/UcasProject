﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    public  class ProjectProfileCmd
    {
      static  UcasProEntities db = new UcasProEntities();

      public static List<ProjectProfile> GetAllProjects()
        {
            db = new UcasProEntities();
            var lst = (from p in db.ProjectProfiles
                       orderby p.StartDate  ascending 
                       select p).ToList();
            return lst;
        }
      public static bool AddNewProject(ProjectProfile tb)
        {
            db = new UcasProEntities();
            db.ProjectProfiles.Add(tb);
            db.SaveChanges();
            return true;
        }

      public static bool EditProjectProfile(ProjectProfile ptb)
         
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectProfiles.Where(p => p.ID == ptb.ID).SingleOrDefault();
                q.ProjectName = ptb.ProjectName;
                q.ProjectDescription = ptb.ProjectDescription;
                q.StartDate = ptb.StartDate;
                q.EndDate = ptb.EndDate;
                q.Status = ptb.Status;
                q.progress = ptb.progress;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }


      public static bool DeleteProjectProfile(int xid)
        {
            try
            {
                db = new UcasProEntities();
                ProjectProfile tb = new ProjectProfile();
                tb = db.ProjectProfiles.Where(prj => prj.ID == xid).Single();
                if (tb.ID != 0)
                {
                    db.ProjectProfiles.Remove(tb);
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
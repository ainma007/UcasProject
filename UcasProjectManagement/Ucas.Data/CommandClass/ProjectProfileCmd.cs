using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    public  class ProjectProfileCmd
    {
        UcasProEntities db = new UcasProEntities();

        public List<ProjectProfile> GetAllProjects()
        {
            db = new UcasProEntities();
            var lst = (from p in db.ProjectProfiles
                       orderby p.StartDate  ascending 
                       select p).ToList();
            return lst;
        }
        public bool AddNewProject(ProjectProfile tb)
        {
            db = new UcasProEntities();
            db.ProjectProfiles.Add(tb);
            db.SaveChanges();
            return true;
        }

        public bool EditProjectProfile(int xid,string nam , string descp,
            DateTime SDate,DateTime EDate,
            string STUS , int prg, double cost ,string con)
        {
            try
            {
             db = new UcasProEntities();
             ProjectProfile tb = new ProjectProfile();
             tb = db.ProjectProfiles.Where(prj => prj.ID == xid).Single();
             if (tb.ID != 0)
             {
                 tb.ProjectName = nam;
                 tb.ProjectDescription = descp;
                 tb.StartDate = SDate;
                 tb.EndDate = EDate;
                 tb.Status = STUS;
                 tb.progress = prg;
                 tb.TotalCost = cost;
                 tb.Coin = con;
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


        public bool DeleteProjectProfile(int xid)
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

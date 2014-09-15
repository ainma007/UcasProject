using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    public class ProjectControlCmd
    {
           UcasProEntities   db = new UcasProEntities();
           public List<ProjectControl> GetAllProControls() {
               db = new UcasProEntities();
               return db.ProjectControls.ToList();
           
           }
           public bool AddNewProControl(ProjectControl tb)
           {
               db = new UcasProEntities();
               db.ProjectControls.Add(tb);
               db.SaveChanges();
               return true;
           }

           public bool EditProControl(int xid, int uid, int pid, string stats)
           {
               try
               {
                   ProjectControl tb = new ProjectControl();
                   db = new UcasProEntities();
                   tb = db.ProjectControls.Where(pr => pr.ID == xid).Single();
                   if (tb.ID  != 0)
                   {
                       tb.UserID = uid; tb.ProjectID = pid; tb.Status = stats;
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

           public bool EditProControl(int xid)
           {
               try
               {
                   ProjectControl tb = new ProjectControl();
                   db = new UcasProEntities();
                   tb = db.ProjectControls.Where(pr => pr.ID == xid).Single();
                   if (tb.ID != 0)
                   {
                       db.ProjectControls.Remove(tb);
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

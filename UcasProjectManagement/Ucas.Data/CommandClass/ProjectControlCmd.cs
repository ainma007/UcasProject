using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    public class ProjectControlCmd
    {
        static UcasProEntities db = new UcasProEntities();
        public static List<ProjectControl> GetAllProControls()
        {
               db = new UcasProEntities();
               return db.ProjectControls.ToList();
           
           }
        public static bool AddNewProControl(ProjectControl tb)
           {
               db = new UcasProEntities();
               db.ProjectControls.Add(tb);
               db.SaveChanges();
               return true;
           }

        public static bool EditProControl(ProjectControl tb)
           {
               try
               {
                   
               db = new UcasProEntities();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               var q = db.ProjectControls.Where(p => p.ID == tb.ID).SingleOrDefault();
               q.UserID = tb.UserID;
               q.ProjectID = tb.ProjectID;
               q.Status = tb.Status;
               db.SaveChanges();
               return true;
                      
                                  
               }
               catch (Exception)
               {

                   return false;
               }
           }

        public static bool EditProControl(int xid)
           {
               try
               {
                   ProjectControl tb = new ProjectControl();
                   db = new UcasProEntities();
                   tb = db.ProjectControls.Where(pr => pr.ID == xid).SingleOrDefault();
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

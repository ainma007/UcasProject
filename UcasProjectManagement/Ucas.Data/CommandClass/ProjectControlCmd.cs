using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections;
namespace Ucas.Data.CommandClass
{
    public class ProjectControlCmd
    {
        static UcasProEntities db = new UcasProEntities();

        #region  "  ^^^^ Main "
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

        public static string GetStatusByID(int xid) {

            db = new UcasProEntities();
            string  xxx = (from u in db.ProjectControls
            where u.UserID == xid
            select u.Status)

                            .Single();
            return xxx;  
        
        }
        #endregion



        #region  "  ^^^^ Project Profile & Control "
        //= ProjectID == جلب جميع المشاريع التابعه لليوزر الحالي ID
        public static List<ProjectProfile> GetAllCurrentUserProjects()
        {
            db = new UcasProEntities();
            var getallproject = new object ();
            
           // var q = (from i in db.ProjectControls where i.UserID == InformationsClass.xCurrentUserID select i).ToList();
            var q = db.UserTbs.Where(p => p.ID == InformationsClass.xCurrentUserID).Take(1).SingleOrDefault();
            var cn = q.ProjectControls.ToList();
            List<ProjectProfile> ls = new List<ProjectProfile>();
            foreach (var item in cn)
            {
                ls.Add(item.ProjectProfile);
            }
            return ls;
      
        }

       

        #endregion 





        public static int ChkProjectIDByUserID(int xid)
        {
            try
            {
                     db = new UcasProEntities();
                       int  xGetHim = (from u in db.ProjectControls
                        where u.UserID == xid
                          select u.ID)
                          .SingleOrDefault();
            return xGetHim; 
            }
            catch (Exception)
            {
                return 0 ;
               
            }
        }

        
    }
}





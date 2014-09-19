using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    // Starting  { 15/09/2014 }
   public  class GroupCmd
    {
       static UcasProEntities db = new UcasProEntities();

       public static bool AddGroup(GroupsTb xgtb)
        { 
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;

           db.GroupsTbs.Add(xgtb); 
           db.SaveChanges(); 
           return true; 
       }



        public List<GroupsTb> GetAllGroups() { db = new UcasProEntities(); return db.GroupsTbs.ToList(); }


        public static bool DeleteGroup(int xid)
        {
            try
            {
                db = new UcasProEntities();
                GroupsTb gtb = new GroupsTb();
                gtb = db.GroupsTbs.Where(g => g.ID == xid).Single();
                if (gtb.ID != 0)
                {
                    db.GroupsTbs.Remove(gtb);
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

        public static bool EditGroup(GroupsTb g)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.GroupsTbs.Where(p => p.ID == g.ID).SingleOrDefault();
                q.GroupName = g.GroupName;
                q.Description = g.Description;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }


        }
        public static int  GetLastGroupID()
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var GLast = (from g in db.GroupsTbs where g.ID != 0 select g.ID).Last();
            return GLast;
        }
    }
}

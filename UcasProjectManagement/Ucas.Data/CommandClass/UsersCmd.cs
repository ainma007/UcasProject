using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Ucas.Data.CommandClass
{
   public  class UsersCmd
    {
      static UcasProEntities db = new UcasProEntities();
       public static List<UsersTb> GetAllUsers()
       {
           db = new UcasProEntities();
           return db.UsersTbs.ToList();
       }
       public static bool AddUser(UsersTb tb)
       {
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;

           db.UsersTbs.Add(tb);
           db.SaveChanges();
           return true;
       }

       public static bool EditUser(UsersTb tb)
       {
           try
           {
               db = new UcasProEntities();
               var q = db.UsersTbs.Where(p => p.ID == tb.ID).SingleOrDefault();
               q.UserName = tb.UserName;
               q.Password = tb.Password;
               q.GroupID = tb.GroupID;
               db.SaveChanges();
               return true;
               }
              
         
           catch (Exception)
           {

               return false;
           }
       }

       public static bool DeleteUser(int xid)
       {
           try
           {
               db = new UcasProEntities();
               UsersTb tb = new UsersTb();
               tb = db.UsersTbs.Where(u => u.ID == xid).Single();
               if (tb.ID != 0)
               {
                   db.UsersTbs.Remove(tb);
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

       public static int GetLastUserID()
       {

           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;
           int XlAST = (from ueser in db.UsersTbs where ueser.ID != 0 select ueser.ID).Max();
           return XlAST;
       }

       public static int GetCurrentUserIDByNameAndPass(string nam, string pass)
       {
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;
           var lst = (from u in db.UsersTbs where u.UserName == nam && u.Password == pass select u.ID).Single();
           return lst;
       }

       public static List<UsersTb> GetLoginUserDataByID(int XID)
       {
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;
           var lst = (from u in db.UsersTbs where u.ID == XID select u).ToList();
           return lst;
       }

    }
}

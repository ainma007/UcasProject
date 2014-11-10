using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections;

namespace Ucas.Data.CommandClass
{
   public  class UsersCmd
    {
      static UcasProEntities db = new UcasProEntities();
       public static List<UserTb> GetAllUsers()
       {
           db = new UcasProEntities();
           return db.UserTbs.ToList();
       }
     
       public static bool EditUser(UserTb tb)
       {
           try
           {
               db = new UcasProEntities();
               var q = db.UserTbs.Where(p => p.ID == tb.ID).SingleOrDefault();
               q.UserName = tb.UserName;
               q.Password = tb.Password;
              
             
             
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
               UserTb tb = new UserTb();
               tb = db.UserTbs.Where(u => u.ID == xid).Single();
               if (tb.ID != 0)
               {
                   db.UserTbs.Remove(tb);
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
           int XlAST = (from ueser in db.UserTbs where ueser.ID != 0 select ueser.ID).Max();
           return XlAST;
       }

       public static int GetCurrentUserIDByNameAndPass(string nam, string pass)
       {
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;
           var lst = (from u in db.UserTbs where u.UserName == nam && u.Password == pass select u.ID).Single();
           return lst;
       }

       public static List<UserTb> GetLoginUserDataByID(int XID)
       {
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;
           var lst = (from u in db.UserTbs where u.ID == XID select u).ToList();
           return lst;
       }

       public static UserPermession LoadPermession(int ID)
       {
           db = new UcasProEntities();
           return db.UserPermessions.Where(p => p.UserID == ID).SingleOrDefault();

       }
       public static bool UserPermessioSave(UserPermession u)
       {
           db = new UcasProEntities();
           db.UserPermessions.Add(u);
           return true;
       }

       public static UserTb Login(string usr, string pwd)
       {
           try
           {
               var q = db.UserTbs.Where(p => p.UserName == usr && p.Password == pwd).ToList();
               if (q.Count == 0 || q.Count == -1)
               {
                   return new UserTb();
               }
               else
               {
                   return q[0];
               }

           }
           catch (Exception e)
           {
               
               throw e;
           }
       }

       public static List<SystemPermession> GetAllSystemPermession()
       {
           db = new UcasProEntities();
           return db.SystemPermessions.ToList();


       }
       public static void EditPermessionValue(UserPermession u)
       {
           var q = db.UserPermessions.Where(p => p.ID == u.ID).SingleOrDefault();
           q.PermessioID = u.PermessioID;
           q.PermessionValue = u.PermessionValue;
           q.UserID = u.UserID;
           db.SaveChanges();
       }

       public static void SaveUserPermession(UserPermession p)
       {
           db.UserPermessions.Add(p);
           db.SaveChanges();
       }
       //=============================


    }
}

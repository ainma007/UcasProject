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
           var lst = (from p in db.UserTbs

                      select p).ToList();
           return lst;
       }
       public static bool NewUser(UserTb tb)
       {

           db = new UcasProEntities();

           db.UserTbs.Add(tb);
           db.SaveChanges();
           return true;

       }
       
       public static bool EditUser(UserTb tb)
       {
           try
           {
               db = new UcasProEntities();
               var q = db.UserTbs.Where(p => p.ID == tb.ID).SingleOrDefault();
               q.ID = tb.ID;
               q.UserName = tb.UserName;
               q.Password = tb.Password;
               q.TypeUser = tb.TypeUser;
              
             
             
               db.SaveChanges();
               return true;
               }
              
         
           catch (Exception ex)
           {

               throw ex;
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
           db.UserPermessions.Load();

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
                   return null;
               }
               else
               {
                   return q[0];
               }

           }
           catch (Exception e)
           {
               
               throw ;
           }
       }

       public static List<SystemPermession> GetAllSystemPermession()
       {
           db = new UcasProEntities();
           var q =  db.SystemPermessions.ToList();
           return q;

       }
       public static bool  EditPermessionValue(UserPermession u,int xxUserID)
       {
           var q = db.UserPermessions.Where(p => p.ID == u.ID && p.UserID == xxUserID ).SingleOrDefault();
           try
           {
               if (q.ID != 0)
               {
                   q.PermessioID = u.PermessioID;
                   q.PermessionValue = u.PermessionValue;
                   q.UserID = u.UserID;
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

       public static void SaveUserPermession(UserPermession p)
       {
           db.UserPermessions.Add(p);
           db.SaveChanges();
       }
       //=============================

       public static List<UserPermession> GetAllUserPermissonsByUserID(int UsrID )
       {
           db = new UcasProEntities();
           var LST = (from u in db.UserPermessions where u.UserID == UsrID   select u).ToList();
           return LST;
       }


       public static bool  ClearAllUserPermessions(int usrid)
       {
           db = new UcasProEntities();
           UserPermession tb = new UserPermession();
           var lst = (from u in db.UserPermessions where u.UserID == usrid select u).ToList();

           List<int> IDes = new List<int>();
           IDes.Clear();
           foreach (var i in lst )
           {
               IDes.Add(i.ID );
           }
           foreach (var item in IDes )
           {
               
                tb = db.UserPermessions.Where(x => x.ID == item   ).Single();
               db.UserPermessions.Remove(tb);
               db.SaveChanges();
                
           }

           return true; 
       }
    }
}

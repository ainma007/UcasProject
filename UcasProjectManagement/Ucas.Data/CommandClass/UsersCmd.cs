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
       public static bool AddUser(UserTb tb)
       {
           db = new UcasProEntities();
           db.Configuration.ProxyCreationEnabled = false;
           db.Configuration.LazyLoadingEnabled = false;

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
               q.UserName = tb.UserName;
               q.Password = tb.Password;
               q.Group_ID = tb.Group_ID;
             
             
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

       public static IEnumerable GetUserTb()
       {
           db=new UcasProEntities();
           var q = (from i in db.UserTbs
                    join pro in db.ProjectControls on i.ID equals pro.UserID
                    join emp in db.Employees on i.Employee_ID equals emp.ID
                   


                    select new { i.ID, emp.EmployeeName, i.UserName, i.Password, i.Group_ID, pro.UserID, pro.ProjectID, pro.Status }).ToList();
           return q;

       }

    }
}

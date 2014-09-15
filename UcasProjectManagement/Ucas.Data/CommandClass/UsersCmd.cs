using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Ucas.Data.CommandClass
{
   public  class UsersCmd
    {
       UcasProEntities db = new UcasProEntities();
       public List<UsersTb> GetAllUsers()
       {
           db = new UcasProEntities();
           return db.UsersTbs.ToList();
       }
       public bool AddUser(UsersTb tb)
       {
           db = new UcasProEntities();
           db.UsersTbs.Add(tb);
           db.SaveChanges();
           return true;
       }

       public bool EditUser(int xid,string nam ,string pass,int gid)
       {
           try
           {
               db = new UcasProEntities();
               UsersTb tb = new UsersTb();
               tb = db.UsersTbs.Where(u => u.ID == xid).Single();
               if (tb.ID != 0)
               {
                   tb.UserName = nam;
                   tb.Password = pass;
                   tb.GroupID = gid;
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

       public bool DeleteUser(int xid)
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
    }
}

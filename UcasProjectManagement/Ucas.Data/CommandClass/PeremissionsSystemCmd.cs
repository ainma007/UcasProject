using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ucas.Data;

namespace Ucas.Data.CommandClass
{
   public static  class PeremissionsSystemCmd
    {
     static  UcasProEntities db = new UcasProEntities();
       public static bool AddPeremission(UserPermession tb)
       {
           db = new UcasProEntities();
           db.UserPermessions.Add(tb);
           db.SaveChanges();
           return true;


       }

       public static bool EditPeremission(UserPermession tb)
       {
           db = new UcasProEntities();

           try
           {
               var q = db.UserPermessions.Where(g => g.UserID == tb.UserID).Single();
               if (q.ID != 0 && q.UserID != 0)
               {
                   q.PermessionValue = tb.PermessionValue;
                   db.SaveChanges();
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception)
           {
               
               throw;
           }

          
       }
       public static List<UserPermession> GetAllUserPeremissionsByID(int XID)
       {
           db = new UcasProEntities();
           var LST = (from u in db.UserPermessions
                      where u.UserID == XID
                      select u).ToList();
           return LST;

       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Ucas.Data.CommandClass
{
   public  class FinanciersCmd
    {

    static   UcasProEntities db = new UcasProEntities();

    public static List<Thefinancier> GetAllFinanciers()
       {
           db = new UcasProEntities();
           var Lst = (from f in db.Thefinanciers orderby f.Name ascending select f).ToList();
           return Lst;
       }
    public static bool AddFinancier(Thefinancier finc)
       {
           db = new UcasProEntities();
           db.Configuration.LazyLoadingEnabled = false;
           db.Configuration.ProxyCreationEnabled = false;
           db.Thefinanciers.Add(finc);
           db.SaveChanges();
           return true;
       }


    public static bool Editfinancier(Thefinancier finc)
    {
        try
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var q = db.Thefinanciers.Where(p => p.ID == finc.ID).SingleOrDefault();
            q.Name = finc.Name;
            q.agentName = finc.agentName;
            q.PhoneNumber = finc.PhoneNumber;
            q.Fax = finc.Fax;
            q.Email = finc.Email;
            q.Adderss = finc.Adderss;


            db.SaveChanges();
            return true;

        }
        catch (Exception ex)
        {


            return false;
        }
    }

    public static bool DeleteFinancier(int xid)
       {
           try
           {
               db = new UcasProEntities();
               Thefinancier tb = new Thefinancier();
               tb = db.Thefinanciers.Where(f => f.ID == xid).Single();

               if (tb.ID != 0)
               {
                   db.Thefinanciers.Remove(tb);
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

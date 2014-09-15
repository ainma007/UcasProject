using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Ucas.Data.CommandClass
{
   public  class FinanciersCmd
    {

       UcasProEntities db = new UcasProEntities();

       public List<Thefinancier> GetAllFinanciers()
       {
           db = new UcasProEntities();
           var Lst = (from f in db.Thefinanciers orderby f.Name ascending select f).ToList();
           return Lst;
       }
       public bool AddFinancier(Thefinancier tb)
       {
           db = new UcasProEntities();
           db.Thefinanciers.Add(tb);
           db.SaveChanges();
           return true;
       }


       public bool EditFinancier(int xid, string nam, string agntnam, string phn, string fx, string eml, string adrs)
       {
           try
           {
            db = new UcasProEntities();
            Thefinancier tb = new Thefinancier();
            tb = db.Thefinanciers.Where(f => f.ID == xid).Single();

            if (tb.ID != 0)
            {
                tb.Name = nam;
                tb.agentName = agntnam;
                tb.PhoneNumber = phn;
                tb.Fax = fx;
                tb.Email = eml;
                tb.Adderss = adrs;
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

       public bool DeleteFinancier(int xid)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ucas.Data.CommandClass
{
   public class SuppliersCmd
    {
     static  UcasProEntities db = new UcasProEntities();

             
       public static bool newSupplier(Supplier Sup)
       {
           
               db = new UcasProEntities();
               db.Configuration.ProxyCreationEnabled = false;
               db.Configuration.LazyLoadingEnabled = false;
               db.Suppliers.Add(Sup);
               db.SaveChanges();
               return true;

           
          
       }

       public static bool EditSupplier(Supplier Sup)
       {
          
               db = new UcasProEntities();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               var q = db.Suppliers.Where(p => p.ID == Sup.ID).SingleOrDefault();
               q.Name = Sup.Name;
               q.SuppliersNatural = Sup.SuppliersNatural;
               q.PhoneNumber = Sup.PhoneNumber;
               q.Fax = Sup.Fax;
               q.Email = Sup.Email;
               q.Adderss = Sup.Adderss;
               db.SaveChanges();
               return true;

           
          
       }

       public static bool DeleteSupplier(int ID)
       {
           try
           {
               db = new UcasProEntities();

               var q = db.Suppliers.Where(p => p.ID == ID).SingleOrDefault();
               db.Suppliers.Remove(q);
               db.SaveChanges();
               return true;
           }
           catch (Exception)
           {

               return false;
           }
              
         
          
       }

       public static List<Supplier> GetAll()
       {
           db = new UcasProEntities();
           db.Configuration.LazyLoadingEnabled = false;
           db.Configuration.ProxyCreationEnabled = false;
           return db.Suppliers.ToList();
       }
    }
}

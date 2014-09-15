using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
  public  class SalariesCmd
    {


        static UcasProEntities db = new UcasProEntities();
        public static bool NewSalary(Salary tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.Salaries.Add(tb);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditSalary(Salary tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Salaries.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.ContractID = tb.ContractID;
                q.Dateofexchange = tb.Dateofexchange;
                q.Salary1 = tb.Salary1;
                q.Formonth = tb.Formonth;
               

                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteSalary(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Salaries.Where(p => p.ID == ID).SingleOrDefault();
                db.Salaries.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<Salary> GetAll()
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.Salaries.ToList();
        }
    }
}

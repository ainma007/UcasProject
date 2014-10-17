using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
  public  class SalariesCmd
    {


        static UcasProEntities db = new UcasProEntities();
        public static bool NewSalary(Monthlysalary tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.Monthlysalaries.Add(tb);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditSalary(Monthlysalary tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Monthlysalaries.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.ContractID = tb.ContractID;
                q.IssueDate = tb.IssueDate;
                q.Amount = tb.Amount;
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
                var q = db.Monthlysalaries.Where(p => p.ID == ID).SingleOrDefault();
                db.Monthlysalaries.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<Monthlysalary> GetAllSalaries()
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.Monthlysalaries.ToList();
        }
        public static List<Monthlysalary> GetSalaryBySelectedContractID(int ContID) {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = (from c in db.Monthlysalaries
                       where c.ContractID == ContID 
                       select c).ToList();
            return LST;
        }


        public static IEnumerable GetAllSalaryBypro(int ProId)
        {
            db = new UcasProEntities();
            var q = (from i in db.Monthlysalaries
                     join Cont in db.Contracts on i.ContractID equals Cont.ID
                     join emp in db.Employees on Cont.Employee_ID equals emp.ID
                     where i.ProjectProfile_ID == ProId




                     select new { i.ID, emp.EmployeeName, i.IssueDate, i.Formonth, i.Amount, i.ContractID, i.ProjectProfile_ID }).ToList();
            return q;

        }

    }
}

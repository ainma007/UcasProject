using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
   public class ProjectExpensesCmd
    {

        static UcasProEntities db = new UcasProEntities();
        public static bool NewProjectExpens(ProjectExpens tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.ProjectExpenses.Add(tb);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditProjectExpens(ProjectExpens tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectExpenses.Where(p => p.ID == tb.ID).SingleOrDefault();
                q.ExpensesName = tb.ExpensesName;
                q.DateofProcess = tb.DateofProcess;
                q.BillNumber = tb.BillNumber;
                q.RequiarAmount = tb.RequiarAmount;
                q.CashingNumber = tb.CashingNumber;
                q.ProjectSubActivity_ID = tb.ProjectSubActivity_ID;
                q.Supplier_ID = tb.Supplier_ID;


                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteProjectExpens(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectExpenses.Where(p => p.ID == ID).SingleOrDefault();
                db.ProjectExpenses.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<ProjectExpens> GetAllBySubActivity(int SubActivityID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = (from p in db.ProjectExpenses
                       orderby p.DateofProcess ascending 
                       where p.ProjectSubActivity_ID == SubActivityID
                       select p).ToList();
            return LST;
        }

        public static List<ProjectExpens> GetAllExpensesBySupplier(int SupplID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = (from p in db.ProjectExpenses
                       orderby p.DateofProcess ascending 
                       where p.Supplier_ID  == SupplID
                       select p).ToList();
            return LST;
        }

    }
}

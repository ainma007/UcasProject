using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
   public class ProjectExpensesCmd
    {

        static UcasProEntities db = new UcasProEntities();
        public static double GetTotalExpensesByProject(int ProID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = (from p in db.ProjectExpenses
                       orderby p.DateofProcess ascending
                       where p.ProjectProfile_ID == ProID
                       select p.CashingNumber).ToList();

            double total = 0;
            foreach (var Sm in LST) { total += Convert.ToDouble(Sm); }

            return total;

        }

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


        public static List<ProjectExpens> GetAllExpensesByProject(int ProID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var LST = (from p in db.ProjectExpenses
                       orderby p.DateofProcess ascending
                       where p.ProjectProfile_ID == ProID
                       select p).ToList();
            return LST;
        }
        public static IEnumerable ExpensesByProjectID(int ProID)
        {
            db = new UcasProEntities();
            var q = (from i in db.ProjectExpenses
                     join subA in db.ProjectSubActivities on i.ProjectSubActivity_ID equals subA.ID
                     join supplier in db.Suppliers on i.Supplier_ID equals supplier.ID

                     where i.ProjectProfile_ID == ProID

                     select new { i.ID, i.ExpensesName, i.BillNumber, i.DateofProcess,i.RequiarAmount, i.CashingNumber, subA.SubActivityName, supplier.Name, i.ProjectSubActivity_ID,i.Supplier_ID }).ToList();
            return q;

        }
        }
    }


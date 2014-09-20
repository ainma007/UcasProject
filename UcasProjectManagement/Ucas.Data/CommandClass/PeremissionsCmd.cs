using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    public   class PeremissionsCmd
    {
        static UcasProEntities db = new UcasProEntities();

        public static List<PeremissionsTb> GetAllPeremissions(int xid )
        {
            db = new UcasProEntities();
            var lst = (from p in db.PeremissionsTbs where p.GroupID == xid  select p).ToList();
            return lst;
        }
        public static bool AddPeremissions(PeremissionsTb tb)
        {
            db = new UcasProEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            db.PeremissionsTbs.Add(tb);
            db.SaveChanges();
            return true;
        }

        public static bool EditPeremissions(PeremissionsTb tb)
        {
            try
            {
               
                db = new UcasProEntities();
                var q = db.PeremissionsTbs.Where(p => p.GroupID  == tb.GroupID && p.ID == tb.ID  ).SingleOrDefault();
                if (tb.ID != 0)
                {
                    q.GroupID = tb.GroupID;
                    q.AddUser = tb.AddUser;
                    q.UpDateUser = tb.UpDateUser;
                    q.DeleteUser = tb.DeleteUser;

                    q.AddProject = tb.AddProject;
                    q.DisplayExpenses = tb.DisplayExpenses;
                    q.CanPrint = tb.CanPrint;

                    q.AddEmployee = tb.AddEmployee;
                    q.DeleteEmployee = tb.DeleteEmployee;
                    q.EditEmployee = tb.EditEmployee;


                    q.AddSuppliers = tb.AddSuppliers;
                    q.EditSuppliers = tb.EditSuppliers;
                    q.DeleteSuppliers = tb.DeleteSuppliers;

                    q.AddFinncers = tb.AddFinncers;
                    q.EditFinncers = tb.EditFinncers;
                    q.DeleteFinncers = tb.DeleteFinncers;

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
        public bool DeletePeremissions(int ID)
        {
            db = new UcasProEntities();
            try
            {
             //   PeremissionsTb tb = new PeremissionsTb();
               db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.PeremissionsTbs.Where(p => p.ID == ID).SingleOrDefault();
                db.PeremissionsTbs.Remove(q);
                db.SaveChanges();
                return true;
                }
               
           
            catch (Exception)
            {

                return false;
            }

        }
        public static  int  GetPermissionsByGroupID(int GID)
        {
            db = new UcasProEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            var TheTargetRec = (from p in db.PeremissionsTbs
                                where p.GroupID == GID
                                select p.ID).Single();
            return TheTargetRec;
        }
    }
}

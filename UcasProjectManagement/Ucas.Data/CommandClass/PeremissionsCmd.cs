using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
    public   class PeremissionsCmd
    {
        UcasProEntities db = new UcasProEntities();

        public List<PeremissionsTb> GetAllPeremissions()
        {
            db = new UcasProEntities();
           return  db.PeremissionsTbs.ToList();
        }
        public bool AddPeremissions(PeremissionsTb tb)
        {
            db = new UcasProEntities();
            db.PeremissionsTbs.Add(tb);
            db.SaveChanges();
            return true;
        }

        public bool EditPeremissions(int xid,int gid,int aduser,int updateusr,int delusr,
            int adprj,int exp,int prnt,int ademp,int delemp,int editemp,
          int adsup, int delsup, int edtsup, int adfin, int delfin, int edtfin)
        {
            try
            {
                PeremissionsTb tb = new PeremissionsTb();
                db = new UcasProEntities();
                tb = db.PeremissionsTbs.Where(p => p.ID == xid).Single();
                if (tb.ID != 0)
                {
                    tb.GroupID = gid;
                    tb.AddUser = aduser;
                    tb.UpDateUser = updateusr;
                    tb.DeleteUser = delusr;

                    tb.AddProject = adprj;
                    tb.DisplayExpenses = exp;
                    tb.CanPrint = prnt;

                    tb.AddEmployee = ademp;
                    tb.DeleteEmployee = delemp;
                    tb.EditEmployee = editemp;


                    tb.AddSuppliers = adsup;
                    tb.EditSuppliers = edtsup;
                    tb.DeleteSuppliers = delsup;

                    tb.AddFinncers = adfin;
                    tb.EditFinncers = edtfin;
                    tb.DeleteFinncers = delfin;

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
        public bool DeletePeremissions(int xid)
        {
            db = new UcasProEntities();
            try
            {
                PeremissionsTb tb = new PeremissionsTb();
                db = new UcasProEntities();
                tb = db.PeremissionsTbs.Where(p => p.ID == xid).Single();
                if (tb.ID != 0)
                {

                    db.PeremissionsTbs.Remove(tb);
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

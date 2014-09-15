using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
   public  class GroupCmd
    {
        UcasProEntities db = new UcasProEntities();

        public bool AddGroup(GroupsTb gtb)
        { db = new UcasProEntities(); db.GroupsTbs.Add(gtb); db.SaveChanges(); return true; }
        public List<GroupsTb> GetAllGroups() { db = new UcasProEntities(); return db.GroupsTbs.ToList(); }


        public bool DeleteGroup(int xid)
        {
            try
            {
                db = new UcasProEntities();
                GroupsTb gtb = new GroupsTb();
                gtb = db.GroupsTbs.Where(g => g.ID == xid).Single();
                if (gtb.ID != 0)
                {
                    db.GroupsTbs.Remove(gtb);
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

        public bool EditGroup(int xid, string gname, string descrip)
        {
            try
            {
                db = new UcasProEntities();
                GroupsTb gtb = new GroupsTb();
                gtb = db.GroupsTbs.Where(g => g.ID == xid).Single();
                if (xid != 0)
                {
                    gtb.GroupName = gname;
                    gtb.Description = descrip;
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

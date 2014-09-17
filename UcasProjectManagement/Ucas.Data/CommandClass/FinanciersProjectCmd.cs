using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
     public  class FinanciersProjectCmd
    {
      static   UcasProEntities db = new UcasProEntities();

         #region " { Get Current Project's Financiers Only } "
      public static List<TheFinancerProject> GetAllFinanciersOfSelectedProject(int ProjId)
         {
             try
             {
                 if (ProjId != 0)
                 {
                     var CurrentFinanciers = (from Pro in db.TheFinancerProjects
                                              where Pro.ProjectID == ProjId
                                              select Pro).ToList();
                     return CurrentFinanciers;
                 }
                 return null;

             }
             catch (Exception)
             {

                 return null;
             }
         }
    # endregion

      public static bool AddTheFinanciersProject(TheFinancerProject tb)
         {
             db = new UcasProEntities();
             db.TheFinancerProjects.Add(tb);
             db.SaveChanges();
             return true;
         }

      public static bool EditFinanciersProject(int xid, int pid, int fid, double cost)
         {
             try
             {
             db = new UcasProEntities();
                 TheFinancerProject tb = new TheFinancerProject ();
                 tb = db.TheFinancerProjects.Where(f => f.ID == xid).Single();
                 if (tb.ID != 0)
                 {
                     tb.ProjectID = pid; tb.FinacerID = fid; tb.TotalCost = cost;
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

      public static bool DeleteFinanciersProject(int xid)
         {
             try
             {
                 db = new UcasProEntities();
                 TheFinancerProject tb = new TheFinancerProject();
                 tb = db.TheFinancerProjects.Where(f => f.ID == xid).Single();
                 if (tb.ID != 0)
                 {
                     db.TheFinancerProjects.Remove(tb);
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

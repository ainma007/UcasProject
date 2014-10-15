﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public class ContractCmd
    {

        static UcasProEntities db = new UcasProEntities();
        public static bool NewContract(Contract Ct)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.Contracts.Add(Ct);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditContract(Contract Ct)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Contracts.Where(p => p.ID == Ct.ID).SingleOrDefault();
                q.Employee_ID = Ct.Employee_ID;
              //  q.ProjectProfile_ID = Ct.ProjectProfile_ID;
                q.SelaryAmount = Ct.SelaryAmount;
                q.StartDate = Ct.StartDate;
                q.EndDate = Ct.EndDate;
                q.Status = Ct.Status;
                
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteContract(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Contracts.Where(p => p.ID == ID).SingleOrDefault();
                db.Contracts.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static IEnumerable GetAllContractsBypro(int ProId)
        {
            db = new UcasProEntities();
            var q = (from i in db.Contracts
                     join emp in db.Employees on i.Employee_ID equals emp.ID
                     where i.ProjectProfile_ID == ProId




                     select new { i.ID, emp.EmployeeName, i.StartDate,i.EndDate,i.SelaryAmount,i.Status,i.ProjectProfile_ID }).ToList();
            return q;

        }


        public static IEnumerable GetAllContractsForComboBox(int ProId)
        {
            db = new UcasProEntities();
            var q = (from i in db.Contracts
                     join emp in db.Employees on i.Employee_ID equals emp.ID
                     where i.ProjectProfile_ID == ProId




                     select new { i.ID, emp.EmployeeName, emp.EmployeejobNumber }).ToList();
            return q;

        }

    }
}

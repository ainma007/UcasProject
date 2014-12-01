using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
   public class EmployeeCmd
    {

        static UcasProEntities db = new UcasProEntities();
        public static bool addEmployee(Employee emp)
        {
            try
            {
                db = new UcasProEntities();
                
                db.Employees.Add(emp);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static bool EditEmployee(Employee emp)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Employees.Where(p => p.ID == emp.ID).SingleOrDefault();
                q.EmployeeName = emp.EmployeeName;
                q.EmployeejobNumber = emp.EmployeejobNumber;
                q.EmployeeGender = emp.EmployeeGender;
                q.PhoneNumber = emp.PhoneNumber;
                q.Mobilenumber = emp.Mobilenumber;
                q.Email = emp.Email;
                q.EmployeeNationalNumber = emp.EmployeeNationalNumber;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteEmployee(int ID)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Employees.Where(p => p.ID == ID).SingleOrDefault();
                db.Employees.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<Employee> GetAll()
        {
            db = new UcasProEntities();
           
            return db.Employees.ToList();
        }
    }
}

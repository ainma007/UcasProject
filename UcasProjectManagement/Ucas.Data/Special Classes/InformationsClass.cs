using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public    class InformationsClass
    {

    #region "   List Of Peremissions           "
      public static int _GroupID;

      public static int _AddUser;
      public static int _UpDateUser;
      public static int _DeleteUser;

      public static int _AddProject;
      public static int _DisplayExpenses;
      public static int _CanPrint;

      public static int _AddEmployee;
      public static int _DeleteEmployee;
      public static int _EditEmployee;


      public static int _AddSuppliers;
      public static int _EditSuppliers;
      public static int _DeleteSuppliers;

      public static int _AddFinncers;
      public static int _EditFinncers;
      public static int _DeleteFinncers;
        //==============================
      public static int ProjID;
        //=============================
      public static int AdminID;

      static UcasProEntities db = new UcasProEntities();
      public static List<PeremissionsTb> GetAllGroupPeremissionsByGroupID(int GID)
      {
          db = new UcasProEntities();
          db.Configuration.LazyLoadingEnabled = false;
          db.Configuration.ProxyCreationEnabled = false;
         var  ListOfPeremissions = (from g in db.PeremissionsTbs
                                where g.GroupID == GID
                                select g).ToList();
         return ListOfPeremissions;
      }

      #endregion 

      #region "  {Current User's  Data }       "
      //   --- 
      public static int xCurrentUserID;
      public static string xCurrentUserName;
      public static  string xCurrentUserPass;
        
      #endregion 

    }
}

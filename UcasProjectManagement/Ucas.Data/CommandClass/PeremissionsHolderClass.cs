using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public static   class PeremissionsHolderClass
    {
          public int GroupID;
          public int AddUser ;
          public int UpDateUser ;
          public int DeleteUser;

          public int AddProject ;
          public int DisplayExpenses; 
          public int CanPrint;

          public int AddEmployee ;
          public int DeleteEmployee ;
          public int EditEmployee ;


          public int AddSuppliers ;
          public int EditSuppliers ;
          public int DeleteSuppliers;

          public int AddFinncers ;
          public int EditFinncers ;
          public int DeleteFinncers ;

         // --- {Current User's  Data }
          public int CurrentUserID;
          public string CurrentUserName;
          public string CurrentUserPass;

    }
}

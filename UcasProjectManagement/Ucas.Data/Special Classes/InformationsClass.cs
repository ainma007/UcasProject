﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public    class InformationsClass
    {

    
        //==============================
      public static int ProjID;
      public static string Coin;
        //=============================
      public static int AdminID;

      static UcasProEntities db = new UcasProEntities();
     

   
      #region "  {Current User's  Data }       "
      //   --- 
      public static int xCurrentUserID;
      public static string xCurrentUserName;
      public static  string xCurrentUserPass;
        
      #endregion 

    }
}

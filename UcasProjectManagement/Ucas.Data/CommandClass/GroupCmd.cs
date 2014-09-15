using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Ucas.Data.CommandClass
{
   public  class GroupCmd
    {
       UcasProEntities Db = new UcasProEntities();

       public List<GroupsTb> GetAllGroups() {
           Db = new UcasProEntities();
           Db.Configuration.LazyLoadingEnabled = false;
           Db.Configuration.ProxyCreationEnabled = false;
           return Db.GroupsTbs.ToList(); 
       
       }
    }
}

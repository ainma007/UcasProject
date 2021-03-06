//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ucas.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public Contract()
        {
            this.Monthlysalaries = new HashSet<Monthlysalary>();
        }
    
        public int ID { get; set; }
        public int Employee_ID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<double> SelaryAmount { get; set; }
        public string Status { get; set; }
        public int ProjectProfile_ID { get; set; }
        public Nullable<double> TotalSalary { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ProjectProfile ProjectProfile { get; set; }
        public virtual ICollection<Monthlysalary> Monthlysalaries { get; set; }
    }
}

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
    
    public partial class ProjectExpens
    {
        public int ID { get; set; }
        public string ExpensesName { get; set; }
        public Nullable<System.DateTime> DateofProcess { get; set; }
        public string BillNumber { get; set; }
        public Nullable<double> RequiarAmount { get; set; }
        public string CashingNumber { get; set; }
        public Nullable<int> ProjectSubActivity_ID { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
        public Nullable<int> ProjectProfile_ID { get; set; }
    
        public virtual ProjectProfile ProjectProfile { get; set; }
        public virtual ProjectSubActivity ProjectSubActivity { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}

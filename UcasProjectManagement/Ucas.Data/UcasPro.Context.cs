﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1405:ComVisibleTypeBaseTypesShouldBeComVisible")]
    public partial class UcasProEntities : DbContext
    {
        public UcasProEntities()
            : base("name=UcasProEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<AmountsReceived> AmountsReceiveds { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Monthlysalary> Monthlysalaries { get; set; }
        public virtual DbSet<ProjectActivity> ProjectActivities { get; set; }
        public virtual DbSet<ProjectControl> ProjectControls { get; set; }
        public virtual DbSet<ProjectExpens> ProjectExpenses { get; set; }
        public virtual DbSet<ProjectProfile> ProjectProfiles { get; set; }
        public virtual DbSet<ProjectSubActivity> ProjectSubActivities { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SystemPermession> SystemPermessions { get; set; }
        public virtual DbSet<TheDonor> TheDonors { get; set; }
        public virtual DbSet<TheDonorsProject> TheDonorsProjects { get; set; }
        public virtual DbSet<UserPermession> UserPermessions { get; set; }
        public virtual DbSet<UserTb> UserTbs { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team10Bsports
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA46Team10BsportsEntities : DbContext
    {
        public SA46Team10BsportsEntities()
            : base("name=SA46Team10BsportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CourtTable> CourtTables { get; set; }
        public virtual DbSet<CustomerTable> CustomerTables { get; set; }
        public virtual DbSet<SlotTable> SlotTables { get; set; }
        public virtual DbSet<TransactionTable> TransactionTables { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shampaz
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shampazEntities : DbContext
    {
        public shampazEntities()
            : base("name=shampazEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BuyFactor> BuyFactors { get; set; }
        public virtual DbSet<BuyFactorItem> BuyFactorItems { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SellFactor> SellFactors { get; set; }
        public virtual DbSet<SellFactorItem> SellFactorItems { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}

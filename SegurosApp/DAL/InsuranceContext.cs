namespace SegurosApp.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using SegurosApp.Models;

    public class InsuranceContext : DbContext
    {
        public InsuranceContext() : base("InsuranceContext")
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Policy> Policies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>().Property(c => c.FirstName).IsRequired();
            modelBuilder.Entity<Client>().Property(c => c.FirstName).HasMaxLength(20);
        }
    }
}
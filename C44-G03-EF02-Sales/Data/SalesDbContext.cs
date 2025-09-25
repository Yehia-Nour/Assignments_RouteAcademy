using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C44_G03_EF02_Sales.Models;
using Microsoft.EntityFrameworkCore;

namespace C44_G03_EF02_Sales.Data
{
    public class SalesDbContext : DbContext
    {
        public DbSet<SalesOffice> SalesOffices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SalesDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesOffice>()
                .HasMany(so => so.Employees)
                .WithMany(e => e.SalesOffices)
                .UsingEntity(j => j.ToTable("SalesOfficeEmployees"));

            modelBuilder.Entity<SalesOffice>()
                .HasOne(so => so.Manager)
                .WithOne(e => e.ManagedOffice)
                .HasForeignKey<SalesOffice>(so => so.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .HasOne(p => p.SalesOffice)
                .WithMany(so => so.Properties)
                .HasForeignKey(p => p.SalesOfficeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .HasMany(p => p.Owners)
                .WithMany(o => o.Properties)
                .UsingEntity(j => j.ToTable("PropertyOwners"));
        }
    }

}

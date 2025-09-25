using C44_G03_EF02_Airline.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Airline.Data
{
    internal class AirlineDbContext : DbContext
    {
        public AirlineDbContext() : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AirlineDbContext; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}

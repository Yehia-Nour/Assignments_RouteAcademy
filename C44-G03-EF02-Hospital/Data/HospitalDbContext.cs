using C44_G03_EF02_Hospital.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Data
{
    internal class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = HospitalDB; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
    }
}

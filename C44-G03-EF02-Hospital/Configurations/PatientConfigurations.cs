using C44_G03_EF02_Hospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Configurations
{
    internal class PatientConfigurations : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasMany(p => p.Consultants)
                .WithMany(c => c.PatientsExamine)
                .UsingEntity(j => j.ToTable("Examine"));

            builder.HasOne(p => p.Consultant)
                .WithMany(c => c.PatientsAssigne)
                .HasForeignKey(p => p.ConsultantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.ConsultantId).IsRequired();

            builder.HasOne(p => p.Ward)
                .WithMany(w => w.Patients)
                .HasForeignKey(p => p.WardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.WardId).IsRequired();
        }
    }
}

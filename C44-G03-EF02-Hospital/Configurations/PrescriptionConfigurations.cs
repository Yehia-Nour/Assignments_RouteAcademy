using C44_G03_EF02_Hospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Configurations
{
    internal class PrescriptionConfigurations : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Patient)
                .WithMany(p => p.Prescriptions)
                .HasForeignKey(p => p.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Nurse)
                .WithMany(n => n.Prescriptions)
                .HasForeignKey(p => p.NurseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Drug)
                .WithMany(d => d.Prescriptions)
                .HasForeignKey(p => p.DrugId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

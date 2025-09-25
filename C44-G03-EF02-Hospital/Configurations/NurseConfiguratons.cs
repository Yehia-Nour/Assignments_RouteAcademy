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
    internal class NurseConfiguratons : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder.HasOne(n => n.WardManage)
                .WithOne(w => w.Nurse)
                .HasForeignKey<Ward>(w => w.NurseId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(n => n.Ward)
                .WithMany(w => w.Nurses)
                .HasForeignKey(n => n.WardId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

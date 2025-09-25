using C44_G03_EF02_Airline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Airline.Configurations
{
    internal class AirCraftConfigurations : IEntityTypeConfiguration<AirCraft>
    {
        public void Configure(EntityTypeBuilder<AirCraft> builder)
        {
            builder.HasMany(a => a.Routes)
                .WithMany(a => a.AirCrafts);

            builder.HasOne(a => a.Crew)
                .WithOne(c => c.AirCraft)
                .HasForeignKey<Crew>(c => c.AirCraftId);
        }
    }
}

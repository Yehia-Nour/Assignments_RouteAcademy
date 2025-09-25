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
    internal class AirlineConfigurations : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.HasMany(a => a.Employees)
                .WithOne(e => e.Airline)
                .HasForeignKey(e => e.AirlineId)
                .IsRequired();

            builder.HasMany(a => a.Transactions)
                .WithOne(t => t.Airline)
                .HasForeignKey(t => t.AirlineId)
                .IsRequired();
        }
    }
}

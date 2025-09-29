using C44_G03_EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF03.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasIndex(s => s.FName)
                .IsUnique(true)
                .HasDatabaseName("Index");

            builder.Property(s => s.FName)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.LName)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.Address)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
        }
    }
}

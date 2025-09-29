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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Instructor)
                .WithOne(i => i.ManagedDepartment)
                .HasForeignKey<Department>(d => d.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.DepartmentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
        }
    }
}

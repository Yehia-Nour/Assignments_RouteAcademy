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
    internal class InstCourseConfigurations : IEntityTypeConfiguration<InstCourse>
    {
        public void Configure(EntityTypeBuilder<InstCourse> builder)
        {
            builder.HasKey(ic => new {ic.InstructorId, ic.CourseId});

            builder.HasOne(ic => ic.Instructor)
                .WithMany(i => i.InstCourse)
                .HasForeignKey(ic => ic.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ic => ic.Course)
                .WithMany(i => i.InstCourse)
                .HasForeignKey(ic => ic.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

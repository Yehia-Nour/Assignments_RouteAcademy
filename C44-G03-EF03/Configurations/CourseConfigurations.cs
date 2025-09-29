using C44_G03_EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace   C44_G03_EF03.Configurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(t => t.TopicId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.Description)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
        }
    }
}

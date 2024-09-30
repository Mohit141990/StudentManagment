using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Core.Configurations
{
    public class EnrollmentsConfiguration
    {
        public void Configure(EntityTypeBuilder<Enrollments> builder)
        {
            builder.Property(x => x.EnrollmentID).IsRequired();
            builder.Property(x => x.StudentID).IsRequired();
            builder.Property(x => x.CourseID).IsRequired();
            builder.Property(x => x.EnrollmentDate).HasColumnType("datetime");
            builder.Property(x => x.Grade).HasMaxLength(20);
        }
    }
}

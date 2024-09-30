using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagment.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Core.Configurations
{
    public class CourseConfiguration
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {

            builder.Property(x => x.CourseID).IsRequired();
            builder.Property(x => x.CourseName).HasMaxLength(100);
            builder.Property(x => x.CourseDescription).HasMaxLength(200);

        }
    }
}

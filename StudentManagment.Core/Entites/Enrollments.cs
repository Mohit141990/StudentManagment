using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Core.Entites
{
    public class Enrollments
    {
        public long EnrollmentID { get; set; }
        public long StudentID { get; set; }
        public long CourseID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Grade { get; set; }
        public virtual Student Students { get; set; }
        public virtual Courses Course { get; set; }
    }
}

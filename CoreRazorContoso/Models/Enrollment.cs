using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRazorContoso.Models
{
    public enum Grades
    {
        First,
        UpperSecond,
        LowerSecond,
        Third,
        Pass,
        Fail
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grades? Grade { get; set; }

        // A student enrolled on a course
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

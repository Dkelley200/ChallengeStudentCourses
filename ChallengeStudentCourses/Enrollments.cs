using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Enrollments
    {
        public Student Student { get; set; }
        public Course Course  { get; set; }
        public int Grade { get; set; }

    }
}
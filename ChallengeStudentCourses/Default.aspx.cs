using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             
  
            */

            List<Course> courses = new List<Course>()
            {
                new Course()
                {
                    CourseId = 1,
                    Name = "Algebra",
                    Students = new List<Student>()
                    {
                        new Student() {StudentId = 300, Name = "Sarah Young"},
                        new Student() {StudentId = 301, Name = "Thomas Wayne"},
                        new Student() {StudentId = 302, Name = "Garrett Black"},
                        new Student() {StudentId = 303, Name = "Candy Cane"},
                        new Student() {StudentId = 304, Name = "Trevor Phillips"}
                    }
                },


                new Course()
                {
                    CourseId = 2,
                    Name = "Writing",
                    Students = new List<Student>()
                    {
                        new Student() {StudentId = 301, Name = "Thomas Wayne"},
                        new Student() {StudentId = 302, Name = "Garrett Black"}
                    }
                },

                new Course()
                {
                    CourseId = 3,
                    Name = "Art",
                    Students = new List<Student>()
                    {
                        new Student() {StudentId = 300, Name = "Sarah Young"},
                        new Student() {StudentId = 303, Name = "Candy Cane"}
                    }
                },

                new Course()
                {
                    CourseId = 4,
                    Name = "Speech",
                    Students = new List<Student>()
                    {
                        new Student() {StudentId = 304, Name = "Trevor Phillips",},
                        new Student() {StudentId = 303, Name = "Candy Cane"},
                        new Student() {StudentId = 301, Name = "Thomas Wayne"}
                    }
                }
            };


            foreach (var course in courses)
            {
                resultLabel.Text += String.Format(" <br/> Courses: {0} , {1} <br/>", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format(" Students: {0}, {1},<br/> ", student.StudentId, student.Name);
                }

            }

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
              */


            Course course1 = new Course() { CourseId = 1, Name = "Algebra" };
            Course course2 = new Course() { CourseId = 2, Name = "Writing" };
            Course course3 = new Course() { CourseId = 3, Name = "Art" };
            Course course4 = new Course() { CourseId = 4, Name = "Speech" };
            Course course5 = new Course() { CourseId = 5, Name = "Sewing" };
            Course course6 = new Course() { CourseId = 6, Name = "Music" };




            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {
                    300, new Student
                    {
                        StudentId = 300,
                        Name = "Sarah Young",
                        Courses = new List<Course>
                            {course1, course3}
                    }
                },
                {
                    301, new Student
                    {
                        StudentId = 301,
                        Name = "Thomas Wayne",
                        Courses = new List<Course>
                            {course1, course2, course4}
                    }
                },
                {
                    302, new Student
                    {
                        StudentId = 302,
                        Name = "Garrett Black",
                        Courses = new List<Course>
                            {course1, course2}
                    }
                },
            };

            foreach (var student in students)
            {
                resultLabel.Text += string.Format("<br/>Student: {0} {1}<br/>", student.Value.StudentId,
                    student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format(" Course: {0} {1} <br/>", course.CourseId, course.Name);
                }
            }



        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
           
             *
             * */





            List<Student> studentx = new List<Student>()
        {
            new Student()
            {
            StudentId = 305,
            Name = "Suzi Walker",
            Enrollment = new List<Enrollments>()
            {
                new Enrollments() {Grade = 92, Course = new Course {CourseId = 1, Name = "Algebra"}},
                new Enrollments() {Grade = 96, Course = new Course {CourseId = 5, Name = "Sewing"}},
            }

            },


            new Student()
            {
            StudentId = 306,
            Name = "Randy Rhodes",
            Enrollment = new List<Enrollments>()
            {
                new Enrollments() {Grade = 91, Course = new Course {CourseId = 6, Name = "Music"}},
                new Enrollments() {Grade = 96, Course = new Course {CourseId = 2, Name = "Writing"}},
            }

            },


        };


            //foreach (var course in courses)
            //{
            //    resultLabel.Text += String.Format(" <br/> Courses: {0} , {1} <br/>", course.CourseId, course.Name);
            //    foreach (var student in course.Students)
            //    {
            //        resultLabel.Text += string.Format(" Students: {0}, {1},<br/> ", student.StudentId, student.Name);
            //    }

            //}


            foreach (var stud in studentx)
            {
                resultLabel.Text += string.Format("<br/> Student: {0} {1}<br/>", stud.StudentId, stud.Name);
                foreach (var enrollment in stud.Enrollment)
                {
                    resultLabel.Text +=
                        String.Format("Enrolled  in: {0} - Grade: {1}<br/>", enrollment.Course.Name, enrollment.Grade);
                }

            ;




            }
        }
    }
}

    

        
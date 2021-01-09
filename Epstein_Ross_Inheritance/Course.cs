using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class Course
    {
        public string _courseTitle { get; set; }
        public string _courseDecsription { get; set; }
        Teacher _teacher { get; set; }
        Student[] _student { get; set; }

        public Course(string courseTitle, string courseDescription, Teacher teacher, Student[] student)
        {
            _courseTitle = courseTitle;
            _courseDecsription = courseDescription;
            _teacher = teacher;
            _student = student;
            
        }

    }
   

}

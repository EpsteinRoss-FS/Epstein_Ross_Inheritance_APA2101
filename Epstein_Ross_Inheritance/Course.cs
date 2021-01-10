using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_CE02
{
    class Course
    {
        public string _courseTitle { get; set; }
        public string _courseDecsription { get; set; }
        public Teacher _teacher { get; set; }
        public Student[] _student { get; set; }
        public Teacher teacher = new Teacher();
        public Student[] student = new Student[0];
        
        public Course(Teacher teacher, Student[] student, string courseTitle = "undefined", string courseDescription = "undefined")
        {
            _courseTitle = courseTitle;
            _courseDecsription = courseDescription;
            _teacher = teacher;
            _student = student;
            
        }

    }
   

}

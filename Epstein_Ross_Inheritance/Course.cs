/** 
 * Ross Epstein
 * CE02 - Inheritance
 * 01-10-2021
 * **/
using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_CE02
{
    class Course
    {
        protected string _courseTitle;
        public string CourseTitle { get { return _courseTitle; } }
        protected string _courseDecsription;
        public string CourseDescription { get { return _courseDecsription; } }
        
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

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
    class Student : Person
    {

        protected int _grade;
        public static int _newGrade;
        public int Grade
        {
            get { return _grade; }
            set
            {
                _ = Grade;
            }
        }
        public Student(string name = "AWAITING NAME", string personDescription = "AWAITING DESCRIPTION", int age = 00, int grade = 0):base(name, personDescription, age)
        {
            _grade = grade;
        }


        
    }
}

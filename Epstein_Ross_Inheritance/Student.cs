using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class Student : Person
    {

        public int _grade { get; set; }
        public Student(string name = "AWAITING NAME", string personDescription = "AWAITING DESCRIPTION", int age = 00, int grade = 0):base(name, personDescription, age)
        {
            _grade = grade;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class Student : Person
    {

        public int _grade { get; set; }
        public Student(string name, string personDescription, int age, int grade):base(name, personDescription, age)
        {
            _grade = grade;
        }
        
    }
}

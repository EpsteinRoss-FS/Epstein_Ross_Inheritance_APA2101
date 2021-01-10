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

        public int _grade { get; set; }
        public Student(string name = "AWAITING NAME", string personDescription = "AWAITING DESCRIPTION", int age = 00, int grade = 0):base(name, personDescription, age)
        {
            _grade = grade;
        }
        
    }
}

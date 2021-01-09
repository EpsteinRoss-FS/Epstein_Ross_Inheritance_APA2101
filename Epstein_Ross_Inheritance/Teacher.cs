using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class Teacher : Person
    {
        public string _teacherInfo { get; set; }

        public Teacher(string name, string personDescription, int age, string teacherInfo):base(name,personDescription,age) 
        {
            _teacherInfo = teacherInfo;
        }     
    }

}

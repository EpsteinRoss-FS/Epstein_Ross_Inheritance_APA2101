using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_CE02
{
    class Teacher : Person
    {
        public string _teacherInfo { get; set; }

        public Teacher(string name = "AWAITING NAME",string personDescription = "AWAITING DESCRIPTION", int age = 00, string teacherInfo = "AWAITING INFO") :base(name,personDescription,age) 
        {

            _teacherInfo = teacherInfo;
        }     
    }

}

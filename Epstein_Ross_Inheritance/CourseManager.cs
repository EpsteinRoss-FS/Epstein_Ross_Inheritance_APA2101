using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class CourseManager
    {

        public CourseManager()
        {
            Console.WriteLine("Testing");
            Student student = new Student("bob", "a guy who does things", 21, 100);
            Console.WriteLine(student._name);
            Console.WriteLine(student._age);
            Console.WriteLine(student._personDescription);
            Console.WriteLine(student._grade);

            Teacher teacher = new Teacher("bob", "a guy who does things", 21, "This teacher likes to rock and roll all night and part of every day");
            Console.WriteLine(teacher._name);
            Console.WriteLine(teacher._age);
            Console.WriteLine(teacher._personDescription);
            Console.WriteLine(teacher._teacherInfo);
        }

    }
}

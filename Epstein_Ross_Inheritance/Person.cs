/** 
 * Ross Epstein
 * CE02 - Inheritance
 * 01-10-2021
 * **/
namespace Epstein_Ross_CE02
{
    class Person
    {

        public string _name { get; set; }
        public string _personDescription { get; set; }
        public int _age { get; set; }

        public Person(string name, string personDescription, int age)
        {
            _name = name;
            _personDescription = personDescription;
            _age = age;
        }
    }
}

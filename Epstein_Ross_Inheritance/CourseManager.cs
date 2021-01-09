using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class CourseManager
    {
        public bool exit = false;
        private static List<string> menu = new List<string> { "Create Course", "Create Teacher", "Add Student", "Display","Exit" };

        public CourseManager()
        {
            /**           Console.WriteLine("Testing");
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
            **/


            //loop the program
            while (!exit)
            {
                Selection();
            }




        }

        public static void Selection()
        {
            int menuLength = menu.Count - 1 ;
            
            
            
            int i = 1;
            foreach (var item in menu)
            {
                Console.WriteLine($"[{i}]:  {item}");
                i++;
            }

            Console.Write("Please make a selection >  ");
            string _userChoice = Console.ReadLine();

            //validate the choice is an integer
            bool isInt = Validation.CheckInt(_userChoice);
            int _userChoiceInt = isInt ? Int32.Parse(_userChoice) : 000;

            //validate the choice is in range of the menu
            bool isInRange = Validation.CheckRange(_userChoiceInt, menuLength + 1);

            //ask again if the validation returns false
            while (!isInt || !isInRange)
            {
                i = 1;
                Console.Clear();
                foreach (var item in menu)
                {
                    Console.WriteLine($"[{i}]:  {item}");
                    i++;
                }
                
                
                Console.Write($"Invalid entry!  Please enter a number between 1 and {menuLength} > ");
                _userChoice = Console.ReadLine();
                isInt = Validation.CheckInt(_userChoice);
                _userChoiceInt = isInt ? Int32.Parse(_userChoice) : 000; ;
                isInRange = Validation.CheckRange(_userChoiceInt, (menuLength + 1));
            }

            //get the text value from the menu index based on user choice
            string chosenItem = menu[_userChoiceInt - 1];
            Console.WriteLine(chosenItem);

            //switch statement to handle the chosen menu item
            switch (chosenItem.ToLower())
            {
                case "create course":


                    break;
                case "create teacher":
            
                    break;
                case "add student":
            
                    break;
                case "display":
            
                    break;
                case "exit":
            
                    break;
                default:
                    break;
            }
            
        }
    }

    }


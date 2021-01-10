﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_CE02
{
    class CourseManager
    {
        public bool exit = false;
        private static List<string> menu = new List<string> { "Create Course", "Create Teacher", "Add Student", "Display","Exit" };

        public CourseManager()
        {
            /**
               Console.WriteLine("Testing");
                       Student student = new Student(grade: 100);
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
            
            //switch statement to handle the chosen menu item
            switch (chosenItem.ToLower())
            {
                case "create course":
                    CreateCourse();
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

        public static void CreateCourse()
        {
            Console.Clear();
            Console.Write("What is the name of the course you would like to create?  >  ");
            string courseName = Console.ReadLine();
            bool courseNameValid = Validation.ValidateString(courseName);

            while (!courseNameValid)
            {
                Console.WriteLine("Invalid Entry!");
                Console.Write("What is the name of the course you would like to create?  >  ");
                courseName = Console.ReadLine();
                courseNameValid = Validation.ValidateString(courseName);
            }
            /**
            _courseTitle = courseTitle;
            _courseDecsription = courseDescription;
            _teacher = teacher;
            _student = student;**/
            Console.Clear();
            Console.Write("What is the description of the course?  >  ");
            string courseDescription = Console.ReadLine();
            bool courseDescriptionValid = Validation.ValidateString(courseDescription);

            while (!courseDescriptionValid)
            {
                Console.WriteLine("Invalid Entry!");
                Console.Write("What is the description of the course?  >  ");
                courseDescription = Console.ReadLine();
                courseDescriptionValid = Validation.ValidateString(courseDescription);
            }


            //create teacher
            //teacher name
            Console.Clear();
            Console.WriteLine("What is the name of the teacher for this course?  >  ");
            string teacherName = Console.ReadLine();
            bool teacherNameValid = Validation.ValidateString(teacherName);
            while (!teacherNameValid)
            {
                Console.WriteLine("Invalid Entry!");
                Console.Write("What is the name of the teacher for this course?  >  ");
                teacherName = Console.ReadLine();
                teacherNameValid = Validation.ValidateString(teacherName);
            }

            //teacher description
            Console.Clear();
            Console.WriteLine("What is the description of the teacher?  >  ");
            string teacherDescription = Console.ReadLine();
            bool teachDescriptionValid = Validation.ValidateString(teacherDescription);
            while (!teachDescriptionValid)
            {
                Console.WriteLine("Invalid Entry!");
                Console.Write("What is the description of the teacher?  >  ");
                teacherDescription = Console.ReadLine();
                teachDescriptionValid = Validation.ValidateString(teacherDescription);
            }

            //teacher age
            Console.Clear();
            Console.WriteLine("How old is the teacher?  >  ");
            string teacherAge = Console.ReadLine();
            bool teacherAgeValid = Validation.CheckInt(teacherAge);
            while (!teacherAgeValid)
            {
                Console.WriteLine("Invalid Entry!");
                Console.Write("How old is the teacher?  >  ");
                teacherAge = Console.ReadLine();
                teacherAgeValid = Validation.CheckInt(teacherAge);
            }

            int teacherAgeInt = teacherAgeValid ? Int32.Parse(teacherAge) : 000;

            //teacher info
            Console.Clear();
            Console.Write("What is the description of the teacher?  >  ");
            string teacherInfo = Console.ReadLine();
            bool teacherInfoValid = Validation.ValidateString(teacherInfo);
            while (!teacherInfoValid)
            {
                Console.WriteLine("Invalid Entry!");
                Console.Write("What is the description of the teacher?  >  ");
                teacherInfo = Console.ReadLine();
                teacherInfoValid = Validation.ValidateString(teacherInfo);
            }


            Teacher newTeacher = new Teacher(teacherName, teacherDescription, teacherAgeInt, teacherInfo);

            //create student
            List<Student> newStudents = new List<Student>();
            bool doneMakingStudents = false;
            int i = 0;
            while (!doneMakingStudents) 
            {
                i++;
                Console.Clear();
                Console.Write($"What is student {i}'s name?  >  ");
                string studentName = Console.ReadLine();

                bool studentNameValid = Validation.ValidateString(studentName);
                while (!studentNameValid) 
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Entry!");
                    Console.Write($"What is student {i}'s name?  >  ");
                    studentName = Console.ReadLine();
                    studentNameValid = Validation.ValidateString(studentName);
                }

                Console.Clear();
                Console.Write($"What is student {i}'s description?  >  ");
                string studentDescription = Console.ReadLine();
                bool studentDescriptionValid = Validation.ValidateString(studentDescription);

                while (!studentDescriptionValid) 
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry!");
                    Console.WriteLine($"What is student {i}'s description?");
                    studentDescription = Console.ReadLine();
                    studentDescriptionValid = Validation.ValidateString(studentDescription);
                }

                Console.Clear();
                Console.Write($"How old is student {i}?  >  ");
                string studentAge = Console.ReadLine();
                bool studentAgeValid = Validation.CheckInt(studentAge);
                
                while (!studentAgeValid) 
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry!");
                    Console.WriteLine($"How old is student {i}?  >  ");
                    studentAge = Console.ReadLine();
                    studentAgeValid = Validation.CheckInt(studentAge);
                }

                int studentAgeInt = Int32.Parse(studentAge);

                Console.Clear();

                Console.Write($"What is student {i}'s grade?  >  ");
                string studentGrade = Console.ReadLine();
                bool studentGradeValid = Validation.CheckInt(studentGrade);
                
                while (!studentGradeValid) 
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry!");
                    Console.Write($"What is student {i}'s grade?  >  ");
                    studentGrade = Console.ReadLine();
                    studentGradeValid = Validation.CheckInt(studentGrade);
                }

                int studentGradeInt = Int32.Parse(studentGrade);

                Student newStudent = new Student(studentName, studentDescription, studentAgeInt, studentGradeInt);

                newStudents.Add(newStudent);

                Console.Clear();

                Console.Write("Would you like to add another student?  Yes/No >  ");
                string addAnotherStudent = Console.ReadLine();

                bool addAnotherStudentValidate = Validation.ValidateString(addAnotherStudent);

                while (!addAnotherStudentValidate || (addAnotherStudent.ToLower() != "yes" && addAnotherStudent.ToLower() != "no")) 
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry!");
                    Console.Write("Would you like to add another student?  Yes/No >  ");
                    addAnotherStudent = Console.ReadLine();
                    addAnotherStudentValidate = Validation.ValidateString(addAnotherStudent);
                }

                if (addAnotherStudent.ToLower() == "yes") { 
                    doneMakingStudents = false; 
                }

                if (addAnotherStudent.ToLower() == "no") { doneMakingStudents = true; }
                
            
            }

            //get length of list
            int studentArrayLength = newStudents.Count;
            Console.WriteLine(studentArrayLength);
//            public Student(string name = "AWAITING NAME", string personDescription = "AWAITING DESCRIPTION", int age = 00, int grade = 0):base(name, personDescription, age)



            //Course newCourse = new Course();







        }
    }
}


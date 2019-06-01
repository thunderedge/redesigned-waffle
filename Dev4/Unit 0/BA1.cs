using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA1
{
    class Test
    {
        public static void Main(string[] args)
        {
            string[] courses = new string[] { "Development", "Analysis", "Skills", "Project" };
            Student s1 = new Student("Sarah", "Smith", 123456, courses);
            Student s2 = new Student("Bill", "Rogers", 654321, courses);
        }
    }

    class Student
    {
        public string firstName;
        public string lastName;
        public int studentNumber;
        public string[] courses;

        //Add a constructor here. Hint: use the Main method and the state to help you 

        public Student(string firstName, string lastName, int studentNumber, string[] courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.courses = courses;
        }
    }
}

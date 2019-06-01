using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA1B
{
    class Person
    {
        public string name;
		public string surname;

        public Person(string name, string surname)
        {
			this.name = name;
			this.surname = surname;
        }

		public string GetName()
		{
			return this.name;
        }
	}
    class Student : Person
	{
        public int passed_exams;
		public int student_number;

        public Student(string name, string surname, int student_number) : base(name, surname)
		{
            this.student_number = student_number;
            this.passed_exams = 0;
		}

		public int GetPassedExams()
		{
            return this.passed_exams;
        }

        public void SetPassedExams(int exams)
		{
            this.passed_exams = exams;
		}
		public int GetStudentNumber() 
		{
			return this.student_number;
		}
    }

	class Tests
	{
        public static void Main(string[] args)
		{
            Student s = new Student("John", "Doe", 871029);
            s.SetPassedExams(5);
            int passedExams = s.GetPassedExams();
            s.SetPassedExams(s.GetPassedExams() + 1);
            int id = s.GetStudentNumber();
            Person p = s as Person;
            string name = p.GetName();
        }
    }
}

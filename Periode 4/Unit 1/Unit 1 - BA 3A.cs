using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA3A
{
    class Simple
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(90);
            Student s3 = new Student("Amit", 88, 60);

            string output1 = "Subject One Marks: " + s1.GetSubjectOneMarks();
            string output2 = "Subject One Marks: " + s2.GetSubjectOneMarks();
            string output3 = "Student name: " + s3.GetStudentName();
            string output4 = "Subject One Marks: " + s3.GetSubjectOneMarks();
            string output5 = "Subject Two Marks: " + s3.GetSubjectTwoMarks();
            Console.WriteLine(s3.GetStudentName());
            Console.Read();
        }
    }
    class Student
    {
        public int SubjectOne;
        public int SubjectTwo;
        public string StudentName;

        //add appropriate constructors here

        public Student()
        {
            StudentName = "StudentName";
            SubjectOne = 0;
            SubjectTwo = 0;
        }

        public Student(int SubjectOne)
        {
            this.SubjectOne = SubjectOne;
        }

        public Student(string StudentName, int SubjectOne, int SubjectTwo)
        {
            this.SubjectOne = SubjectOne;
            this.SubjectTwo = SubjectTwo;
            this.StudentName = StudentName;
        }

        public int GetSubjectOneMarks()
        {
            return this.SubjectOne;
        }

        public int GetSubjectTwoMarks()
        {
            return this.SubjectTwo;
        }
        public string GetStudentName()
        {
            return this.StudentName;
        }
    }
}
using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA6B
{
    public class Person
    {
        public virtual string SayHello()
        {
            return "hello!";
        }
    }

    public class TallPerson : Person
    {
        public override string SayHello()
        {
            return "nice weather up here!";
        }
    }

    public class ShortPerson : Person
    {
        public override string SayHello()
        {
            return "hey, I found a penny!";
        }
    }

    class Student
    {
        string name;
        Person base_Person;

        public Student(string n)
        {
            this.name = n;
            this.base_Person = base_Person;
        }

        public string SayHello()
        {
            return this.name + ": " + this.base_Person.SayHello();
        }

        public void Shrink()
        {
            this.base_Person = new ShortPerson();
        }

        public void Enlarge()
        {
            this.base_Person = new TallPerson();
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            var s = new Student("Marlow");
            var x = s.SayHello();
            s.Enlarge();
            var y = s.SayHello();
            s.Shrink();
            var z = s.SayHello();
        }
    }
}

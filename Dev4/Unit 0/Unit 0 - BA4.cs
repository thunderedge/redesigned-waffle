using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA4
{
    class Test
    {
        public static void Main(string[] args)
        {
            Planet p1 = new Planet("Jupiter", 5.203, 2.5);
            Planet p2 = new Planet("Earth", 1.0, 1.0);
            string n1 = p1.name;
            double d1 = p1.distance;
            double g1 = p1.gravity;
            string s1 = p1.Info();
            string s2 = p2.Info();
        }
    }

    // Create a class named Planet. 
    // Each planet has a name (string), a distance from the sun (double), and its gravity relative to Earth’s gravity (double). 
    // Create a method called Info which returns all the data in the fields.

    class Planet
    {
        public string name;
        public double distance;
        public double gravity;

        public Planet(string name, double distance, double gravity)
        {
            this.name = name;
            this.distance = distance;
            this.gravity = gravity;
        }

        public string Info()
        {
            return "Planet " + this.name + ", distance: "+ this.distance +"AU, gravity: " + this.gravity;
        }
    }

}


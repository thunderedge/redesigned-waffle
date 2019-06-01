using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA3
{
    class Test
    {
        public static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(3.0, 4.0);
            Rectangle r2 = new Rectangle(5.0, 2.0);
            double l = r1.length;
            double w = r1.width;
            double a1 = r1.Area();
            double a2 = r2.Area();
        }
    }

    // Create a class named Rectangle. 
    // The class should have two public fields, length and width (both of type double)
    // The constructor should take in two doubles and assign them to each of the fields
    // There should be one method called Area that returns the area of the rectangle (length x width)  

    class Rectangle
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area()
        {
            return this.length * this.width;
        }
    }

}

using System;
using System.Diagnostics;
using System.Threading;


namespace U1BA5B
{
    class Test
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape(10, 30);
            string shape_dims = shape.GetDims();
            Triangle tri = new Triangle(6, 9);
            string tri_dims = tri.GetDims();
            double area = tri.Area();
        }
    }

    // Write the base class here.

    class Shape
    {
        public double height;
        public double width;

        public Shape(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public virtual string GetDims()
        {
            return "Width: " + width + "; Height: " + height;
        }

        public virtual double Area()
        {
            return height + width - 13;
        }
    }

    // Write the derived class here with a method that can return the Area (w * h /2). 

    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
            this.height = height;
            this.width = width;
        }

        public override string GetDims()
        {
            return base.GetDims();
        }

        public override double Area()
        {
            return width * height / 2;
        }
    }
}

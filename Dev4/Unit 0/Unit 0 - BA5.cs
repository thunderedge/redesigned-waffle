using System;
using System.Diagnostics;
using System.Threading;


namespace U0BA5
{
    class Test
    {
        public static void Main(string[] args)
        {
            var v1 = new Vector2(2.0, 4.0);
            var v2 = new Vector2(5.0, 1.0);
            var r = v1.Times(3.0);
            //var q = v2.Plus(r);
            //var p = v2.Times(q.x + q.y);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    // Write a class named Vector2 which contains two public fields, x and y (of type double).
    // This class should have two methods, Times and Plus. 
    // Times takes a double in input and returns a new Vector2 in which x and y are multiplied by the input value.
    // Plus takes a Vector2 in input and returns a new Vector2 in which the two fields of the object are summed to those of the input vector.

    class Vector2
    {
        public double x;
        public double y;

        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Times(double input)
        {
            return new Vector2(this.x * input, this.y * input);
        }

        public double Plus()
        {

            return 0;
        }
    }

}

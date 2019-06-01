using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA2A
{
    class Compute
    {
        public int Add(int x, int y)
        {
          return x + y;
        }

        public int Add(int x, int y, int z)
        {
          return x + y + z;

        }

        public double Add(double x, int y)
        {
          return x + y + 1.0;

        }

        public double Add(int x, double y)
        {
          return x * y + x;
        }

        public double Add(double x, double y)
        {
          return x + y;
        }

        public static void Main(string[] args)
        {
          var x = new Compute();
          var a = x.Add(3, 5);
          var b = x.Add(3,5, 1);
          var c = x.Add(3.0, 5);
          var d = x.Add(3, 5.0);
          var e = x.Add(3.0, 5.0);
        }
    }
}

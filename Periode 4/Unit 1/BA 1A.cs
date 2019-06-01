using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA1
{
    public class X
    {
        public int a;
        public float b;
        public double c;

        public X()
        {
            this.a = 0;
            this.b = this.a;
            this.c = this.b;
        }
        public double GetC()
        {
            return this.c;
        }
        public static void Main(string[] args)
        {
            X x = new X();
            double x_c = 0.0;
        }
    }
}

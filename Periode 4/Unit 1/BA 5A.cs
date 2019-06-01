using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA5A
{
    class X
    {
        public int a;
        public double b;
        public string c;

        public X(int num)
        {
            this.a = num;
            this.b = this.a * 2;
            this.c = "num " + this.a;
        }

        public int Compute(int v)
        {
            return v + this.a;
        }

        public double Compute(double v)
        {
            return v + this.b;
        }

        public string Compute(string v)
        {
            return v + " " + this.c;
        }

        public static void Main(string[] args)
        {
            X x1 = new X(5);
            X x2 = new X(7);
            var a = x1.Compute(4);
            var b = x1.Compute(4.0);
            var c = x2.Compute(3.0);
            var d = x1.Compute("hello");
            var e = x2.Compute("ciao");
        }
    }
}

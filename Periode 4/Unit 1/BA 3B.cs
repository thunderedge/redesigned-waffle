using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA3B
{
    class A
    {
        public double a;

        public A(int a)
        {
            this.a = a;
        }
        public virtual double GetA()
        {
            return this.a;
        }
    }

    class B : A
    {
        public int b1;

        public B(int b1, int a) : base(a)
        {
            this.b1 = b1;
        }

        public override double GetA()
        {
            return this.b1 * 10.0;
        }
    }

    class Test {

        public static void Main(string[] args)
        {
            B object1 = new B(555, 883);
            double result = object1.GetA();
            A object2 = new B(123, 321);
            result = object2.GetA();
            A object3 = new A(9001);
            result = object3.GetA();
        }
    }
}

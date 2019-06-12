using System;
using System.Diagnostics;
using System.Threading;

namespace U2BA6
{
   class Simple
    {
        public static int Next(int x)
        {
            return x + 1;
        }
     
        public static int Twice(int x)
        {
            return x * 2;
        }

        public static Func<int, int> Then(Func<int, int> f, Func<int, int> g)
        {
            return x => g(f(x));
        }
     
        public static Func<int, int> CallTwice(Func<int, int> f)
        {
            return Then(f, f);
        }
     
        public static void Main(string[] args)
        {
            int y1 = CallTwice(Next)(3);
            int y2 = Then(CallTwice(Next),Twice)(10);
            y1 = y1 + y2;
        }
    }
}

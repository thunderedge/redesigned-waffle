using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA4A
{
    class Simple
    {
        public static void Main(string[] args)
        {
            double n1 = 36.0;
            int x1 = 2;
            int res1 = ComputeAmountOfDivisions(n1, x1);

            double n2 = 1024.0;
            int x2 = 2;
            int res2 = ComputeAmountOfDivisions(n2, x2);

            double n3 = 3333.0;
            int x3 = 3;
            int res3 = ComputeAmountOfDivisions(n3, x3); 
        }

        // The function computes how many times a number n is
        // entirely divisible by a natural number x.
        // For example, when n is 9 and x is 2 the function
        // should return 3, since 9 / 2 is 4, 4 / 2 is 2 and 2/2 is 1,
        // and 1 / 2 does not return a whole number.
        //
        // Input: n and x
        // Output: the amount of divisions
        public static int ComputeAmountOfDivisions(double n, int x)
        {
            int i = 0;
            while (n / x >= 1)
            {
                n = n / x;
                i++;
            }
            return i;
        }
    }
}

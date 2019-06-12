using System;
using System.Diagnostics;
using System.Threading;

namespace U3BA3
{
 static int[] range(int min, int max)
        {
            var length = max;
            var arr = new int[length];
            for (int i =0; i <= max; i = i + 1)
            {
                arr[i] = arr[i] + i;
            }
            return arr;
        }

        static int[] powersOf(int v, int howMany)
        {
            var arr = new int[v];
            arr[0] = v;

            for (int i = 0; i < howMany; i = i + 1)
            {
                arr[i] = arr[i-1] * v;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            var rangeVal = range(3, 7);
            var rangeVal2 = range(-1,5);
            var powersOf2 = powersOf(2, 5);
            var powersOf3 = powersOf(1, 16);
            rangeVal[0] = 6;
            rangeVal2[1] = 6;
            powersOf2[2] = 6;
            powersOf3[3] = 6;
        }
    }
}

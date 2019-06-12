using System;
using System.Diagnostics;
using System.Threading;

namespace U3BA2
{
	class Simple
    {
		static void Main(string[] args)
        {
			int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            array[0] = 99;
            array[9] = 88;
        }
    }
}

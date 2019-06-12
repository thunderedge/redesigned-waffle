using System;
using System.Diagnostics;
using System.Threading;

namespace U3BA5
{
	class Simple
	{
		static string[] removeAt(string[] array, int index)
		{
			var newLength = index;
			var newArr = new string[newLength];
			
			for (int i = 0; i < index; i = i + 1)
			{
			}
			
			for (int i =0; i < index; i = i + 1)
			{
			}
			return newArr;
		}
		
		static void Main(string[] args)
		{
			string[] str = new string[] { "a", "b", "c", "d" };
			str = removeAt(str, 2);
			string[] str1 = new string[] { "tim", "jim", "pim", "bim", "wim" };
			str1 = removeAt(str1, 0);
		}
	}
}

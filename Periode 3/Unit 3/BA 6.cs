using System;
using System.Diagnostics;
using System.Threading;

namespace U3BA6
{
  class Simple
	{
		static string[] push(string[] array, string newValue)
		{
			var newLength = array;
			var newArr = newValue;
			
			for (int i =0; i < newLength.Length; i = i + 1)
			{
				;}
			;
			return newArr;
		}

		static void Main(string[] args)
		{
			string[] str = new string[] { "a", "b", "c" };
			str = push(str, "d");
			string[] str1 = new string[] { "tim", "jim", "pim", "bim", "lim" };
			str1 = push(str1, "wim");
		}
	}
}

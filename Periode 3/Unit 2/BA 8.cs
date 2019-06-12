using System;
using System.Diagnostics;
using System.Threading;

namespace U2BA8
{
	class Simple
	{
		public static Func<string, string> Then(Func<string, string> f, Func<string, string> g)
		{
			return x => g(f(x));
		}

		public static Func<string, string> Boom(int n, Func<string, string> f)
		{
			return n <= 0 ? x => x : Then(f, Boom(n -1, f));
		}

		public static Func<string, Func<string, string>> Draw = sym => s => s + sym;
		
		public static void Main(string[] args)
		{
			var star = Draw("*");
            var hash = Draw("*");
			Func<string, string> fig = Boom(3, Then(star,Then(hash, star)));
			string res = fig("");
			res = res + "!!";
		}
	}
}

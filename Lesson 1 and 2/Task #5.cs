using System;

namespace C_Sharp_Main
{
	class Program
	{
		public static void Main()
		{
			string str = Console.ReadLine();

			char[] charStr = str.ToCharArray();
			Array.Reverse(charStr);

			Console.WriteLine(charStr);
		}
	}
}

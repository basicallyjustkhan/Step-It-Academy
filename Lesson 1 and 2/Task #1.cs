using System;

namespace C_Sharp_Main
{
    class Program
    {
		public static int Task1(string str)
		{
			int strLength = 0;
			string subStr;


			for (int i = 0; i < str.Length; i++)
			{
				subStr = str.Substring(i, 1);
				if (subStr == " ")
				{
					strLength++;
				}
			}

			return strLength;
		}
		public static void Main()
		{
			string str;
			Console.Write("Enter the String: ");
			str = Console.ReadLine();
			Console.WriteLine("Amount of spaces: ", Task1(str));
		}
	}
}

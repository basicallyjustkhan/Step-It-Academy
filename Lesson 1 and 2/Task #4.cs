using System;

namespace C_Sharp_Main
{
	class Program
	{
		public static void Main()
		{
            int x, y;

            Console.Write("First Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second Number: ");
            y = Convert.ToInt32(Console.ReadLine());


            for (; x < y + 1; x++)
            {
                Console.WriteLine(x);
            }
        }
	}
}

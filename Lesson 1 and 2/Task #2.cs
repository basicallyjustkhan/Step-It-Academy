using System;

namespace C_Sharp_Main
{
	class Program
	{
		public static int Task2(int tramTicket)
		{
			int one, two, three, four, five, six;

			one = tramTicket % 10;
			two = tramTicket / 10 % 10;
			three = tramTicket / 100 % 10;
			four = tramTicket / 1000 % 10;
			five = tramTicket / 10000 % 10;
			six = tramTicket / 100000 % 10;

			if (one + two + three == four + five + six)
			{
				Console.WriteLine("True");
			}
			else
            {
				Console.WriteLine("False");
			}

			return 0;
		}
		public static void Main()
		{
			int tramTicket;
			Console.Write("Enter the tram ticket number(6 digit number): ");
			tramTicket = Convert.ToInt32(Console.ReadLine());
			Task2(tramTicket);
		}
	}
}

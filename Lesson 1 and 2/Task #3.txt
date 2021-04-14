using System;

namespace C_Sharp_Main
{
	class Program
	{
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    arr[i] = (char)(arr[i] + 32);
                }
                else
                {
                    arr[i] = (char)(arr[i] - 32);
                }
            }

            Console.WriteLine(arr);
        }
    }
}

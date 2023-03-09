static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(5);
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();
            
            int repeater = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == repeater)
                {
                    count++;
                }
            }
            
            Console.WriteLine(count);
        }
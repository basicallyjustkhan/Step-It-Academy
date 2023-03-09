static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(5);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            // Sort by need
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        temp = 0;
                    }
                }
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            // Swap action
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;
                }
                Console.Write(arr[i] + " ");
            }
        }
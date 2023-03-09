Random random = new Random();
            int[][] arr = new int[10][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[5];
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(0, 100);
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            
            Console.Write("Enter the first column you want to swap: ");
            int swap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second column you want to swap: ");
            int swap1 = Convert.ToInt32(Console.ReadLine());
            
            int[] temp = new int[10];

            for (int i = 0; i < 10; i++)
            {
                temp[i] = arr[i][swap];
            }

            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (j == swap)
                    {
                        arr[i][j] = arr[i][swap1];
                        arr[i][swap1] = temp[k];
                        k++;
                    }
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
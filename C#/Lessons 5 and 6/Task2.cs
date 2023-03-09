static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > 0 && arr[j+1] < 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        temp = 0;
                    }
                    else if (arr[j] == 0)
                    {
                        for (int l = j; l < arr.Length - 1; l++)
                        {
                            temp = arr[l];
                            arr[l] = arr[l + 1];
                            arr[l + 1] = temp;
                            temp = 0;
                        }
                    }
                }
                Console.Write(arr[i] + " ");
            }
        }
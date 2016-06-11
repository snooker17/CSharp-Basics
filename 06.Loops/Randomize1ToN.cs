using System;

    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i+1;
            }
            Shuffle(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }


        }



        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
               
                int r = i + (int)(random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
    }


using System;

namespace _8.Problem_Numbers_from_1_to_n
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

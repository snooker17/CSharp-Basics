using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        int end = int.Parse(Console.ReadLine());

        for (int i = 1; i <= end; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                    
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}


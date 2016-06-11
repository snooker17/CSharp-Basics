using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int end=int.Parse(Console.ReadLine());

        for (int i = 1; i <= end; i++)
        {
            Console.Write(i );
        }
        Console.WriteLine();
    }
}


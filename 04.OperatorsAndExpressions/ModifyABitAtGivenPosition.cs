using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = (mask & n);
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << p;
            int result = (mask | n);
            Console.WriteLine(result);
        }
        

    }
}


using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.Write(i+" ");
            for (int j = i+1,k=1; j <= (n+n)-1 ; j++,k++)
            {
                Console.Write(j+" ");
                if (k == n-1)
                {
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}


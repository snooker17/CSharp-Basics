using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int  k = int.Parse(Console.ReadLine());

        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        uint j =1;
        for (uint i = 1; i <= n; i++)
        {
            if (j < k)
            {
                j++;
                factorielK *= j;
            }
           
           
            factorielN *= i;
            
        }
        BigInteger result = factorielN / factorielK;
        Console.WriteLine("{0:F2}",result);
    }
}


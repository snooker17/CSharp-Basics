using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factoriel2N=Factoriel(2*n);
        BigInteger factorielN1=Factoriel(n+1);
        BigInteger factorielN = Factoriel(n);

        BigInteger numberCatalan = factoriel2N/(factorielN1*factorielN);
        Console.WriteLine(numberCatalan);
       
    }

    public static BigInteger Factoriel(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}


using System;
using System.Numerics;

class CalculateN
{
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorielN=1;
        BigInteger factorielK=1;
        BigInteger factorielNK=1;
        int counterK = 0;
        int counterNK=0;
        for (int i = 1; i <= n; i++)
        {
            if (counterK < k)
            {
                counterK++;
                factorielK *= counterK;
            }
            factorielN *= i;
            if (counterNK < (n - k))
            {
                counterNK++;
                factorielNK *= counterNK;
            }
        }
        BigInteger result = factorielN / (factorielK * (factorielNK));
        Console.WriteLine(result);

    }
}


using System;

class NthDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int nDigit = number / (int)Math.Pow(10, n - 1)%10;
        if (nDigit == 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine(nDigit);
        }

        
    }
}


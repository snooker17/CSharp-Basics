using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());

        bool isPrime=true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if ((number % i) == 0)
            {
                isPrime = false;
            }
           
         
        }
        Console.WriteLine(isPrime);
    }
}


using System;

class CompoundInterest
{
    static void Main()
    {
        double p = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        double bankLoan = p * Math.Pow(1 + i, n);
        double friendLoad = p * (1 + f);

        if (bankLoan > friendLoad)
        {
            Console.WriteLine("{0:F2} Friend",friendLoad);
        }
        else
        {
            Console.WriteLine("{0:F2} Bank",bankLoan);
        }
    }
}


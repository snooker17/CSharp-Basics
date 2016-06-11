using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double factoriel=1;
        double result=1;

        for (int i = 1; i <= n; i++)
        {
          factoriel*=i;
          result += (double)( (factoriel / (Math.Pow(x, i))));
        }
        Console.WriteLine("{0:F5}",result);
    }
}


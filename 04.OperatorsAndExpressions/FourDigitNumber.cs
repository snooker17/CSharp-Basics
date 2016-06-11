using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four digit number:");
        int number = int.Parse(Console.ReadLine());

        int a=number/1000;
        int b=number/100%10;
        int c = number % 100 / 10;
        int d=number%100%10;

        Console.WriteLine(a+b+c+d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}


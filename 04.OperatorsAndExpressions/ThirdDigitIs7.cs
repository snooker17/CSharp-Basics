using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ënter number to be tested:");
        int number = int.Parse(Console.ReadLine());
        bool result;
        if (number / 100%10 == 7)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        Console.WriteLine(result);
    }
}


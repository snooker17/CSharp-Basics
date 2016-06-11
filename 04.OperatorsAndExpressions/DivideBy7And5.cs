using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter number to be tested:");
        int number = int.Parse(Console.ReadLine());
        bool divider;
        if (number % 5 == 0 && number % 7 == 0)
        {
            divider = true;
        }
        else
        {
            divider = false;
        }
        Console.WriteLine(divider);

    }
}


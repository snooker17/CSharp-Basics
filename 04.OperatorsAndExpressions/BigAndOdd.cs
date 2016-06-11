using System;

class BigAndOdd
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result;
        if ((number > 20) && (number % 10 == 1))
        {
            result = true;
        }
        else result = false;
        Console.WriteLine(result);
    }
}


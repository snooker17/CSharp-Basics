using System;

class PureDivisor
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result;
        if ((number % 9 == 0) || (number % 11 == 0)||(number%13==0))
        {
            result = true;
        }
        else result = false;
        Console.WriteLine(result);
    }
}


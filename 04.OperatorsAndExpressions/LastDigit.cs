using System;

class LastDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int LastDigit = n % 10;
       
        Console.WriteLine(LastDigit);
    }
}


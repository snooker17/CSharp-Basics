using System;

class BiggestThreeNum
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        double max = 0;

        if (firstNum > secondNum)
        {
            max = firstNum;
        }
        else
        {
            max = secondNum;
        }

        if (thirdNum > max)
        {
            max = thirdNum;
        }

        Console.WriteLine(max);
    }
}


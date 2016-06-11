using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double firstNum = int.Parse(Console.ReadLine());
        double secondNum = int.Parse(Console.ReadLine());

        if (secondNum < firstNum)
        {
            double temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            
        }
        Console.WriteLine("{0},{1}",firstNum,secondNum);
    
    }
}


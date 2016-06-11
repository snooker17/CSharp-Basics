using System;

class MultiplicationSign
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        int negativeCounter = 0;
        if (firstNum < 0)
        {
            negativeCounter++;
        }

        if (secondNum<0)
        {
            negativeCounter++;
        }

        if (thirdNum < 0)
        {
            negativeCounter++;
        }



        string sign = null;
        if (negativeCounter==1||negativeCounter==3)
        {
            sign = "-";
        }
        else if (negativeCounter==0||negativeCounter==2)
        {
            sign = "+";
        }





        if ((firstNum == 0) || (secondNum == 0) || (thirdNum == 0))
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(sign);
        }


    }
}


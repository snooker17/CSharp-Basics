using System;

class SortThreeNums
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double temp = 0;

        if (secondNum >firstNum)
        {
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            if (thirdNum > secondNum)
            {
                temp = secondNum;
                secondNum = thirdNum;
                thirdNum = temp;
            }
            if (secondNum > firstNum)
            {
                temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
        }
        else
        {
            if (thirdNum > secondNum)
            {
                temp = secondNum;
                secondNum = thirdNum;
                thirdNum = temp;
            }
            if (secondNum > firstNum)
            {
                temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
        }
        Console.WriteLine("{0},{1},{2}",firstNum,secondNum,thirdNum);


    }
}


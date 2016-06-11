using System;

class BiggestOfFiveNum
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double fourthNum = double.Parse(Console.ReadLine());
        double fifthNum = double.Parse(Console.ReadLine());


        double maxBetweenFirstTwoNum = 0;
        double maxBetweenSecondTwoNum = 0;
        double realBiggestNum = 0;
        
        if (firstNum > secondNum)
        {
            maxBetweenFirstTwoNum = firstNum;
        }
        else
        {
            maxBetweenFirstTwoNum = secondNum;
        }



        if (thirdNum > fourthNum)
        {
            maxBetweenSecondTwoNum = thirdNum;
        }
        else
        {
            maxBetweenSecondTwoNum = fourthNum;
        }



        if (maxBetweenFirstTwoNum > maxBetweenSecondTwoNum)
        {
            realBiggestNum = maxBetweenFirstTwoNum;
        }
        else
        {
            realBiggestNum = maxBetweenSecondTwoNum;
        }



        if (fifthNum > realBiggestNum)
        {
            realBiggestNum = fifthNum;
        }


        Console.WriteLine(realBiggestNum);
    }
}


using System;

namespace _1.Problem__Sum_of_3_Numbers
{
    class SumOfNumbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("Sum : {0}",sum);
        }
    }
}

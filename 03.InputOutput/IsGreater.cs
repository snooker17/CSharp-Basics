using System;

namespace _4.Problem_Number_Comparer
{
    class IsGreater
    {
        static void Main()
        {
            Console.Write("a ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("b ");
            double secondNumber = double.Parse(Console.ReadLine());
            double greater = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("greater {0}",greater);
        }
    }
}

using System;

namespace _6.Problem_Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("b ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("c ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double discriminant = (Math.Pow(secondNumber, 2) - (4 * firstNumber * thirdNumber));
            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else 
            {
                double firstRoot = ((-1)*secondNumber + Math.Sqrt(discriminant)) / (2 * firstNumber);
                double secondRoot = ((-1)*secondNumber - Math.Sqrt(discriminant)) / ( 2 * firstNumber);
                if (firstRoot == secondRoot)
                {
                    Console.WriteLine("x1=x2={0:.##}", firstRoot);
                }
                else
                {
                    Console.WriteLine("x1={0:.##}; x2={1:.##}",secondRoot, firstRoot);
                }
            }

        }
    }
}

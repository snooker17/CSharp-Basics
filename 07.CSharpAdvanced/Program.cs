using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
         static int Fibonacci(int count)
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int result = 0;

        if (count == 0)
        {
            Console.WriteLine(secondNumber);
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
        }

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fibonacci(n));
    }
  }
}


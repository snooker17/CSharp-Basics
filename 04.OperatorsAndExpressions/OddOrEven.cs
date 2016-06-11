using System;

class OddOrEven
{
    static void Main()
    {
      
            Console.Write("Enter number to be tested:");
            int number = int.Parse(Console.ReadLine());
            bool even;
            if (number % 2 == 0)
            {
                even = true;
            }
            else even = false;
            Console.WriteLine(even);
      
    }
}


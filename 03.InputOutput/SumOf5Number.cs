using System;

namespace _7.Problem_Sum_of_5_Numbers
{
    class SumOf5Number
    {
        static void Main()
        {
            Console.WriteLine("numbers:");
            string numbers = Console.ReadLine();
            double sum = 0d;
            string[] nums = numbers.Split(' ');
            foreach (string num in nums)
            {
                sum = sum + Convert.ToDouble(num);
            }
            Console.WriteLine("sum : {0:.##}",sum);
        }
    }
}

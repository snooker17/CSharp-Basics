using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number to be compared:");
        double firstNum= double.Parse(Console.ReadLine());

        Console.WriteLine("Enter first second to be compared:");
        double secondNum = double.Parse(Console.ReadLine());

        double epsilon = 0.000001;
        double result = Math.Abs(firstNum - secondNum);

        bool final=(result<=epsilon);

        Console.WriteLine(final);

    }
}


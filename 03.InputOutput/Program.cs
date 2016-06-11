using System;

namespace _3.Problem_Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main()
        {
            Console.Write("r : ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Perimeter : {0:F2}\nArea : {1:F2}", perimeter, area);
        }
    }
}

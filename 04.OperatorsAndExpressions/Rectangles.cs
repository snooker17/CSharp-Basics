using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());

        double perimeter = height + height + width + width;
        double area = height * width;

        Console.WriteLine("Perimeter:{0}\nArea:{1}",perimeter,area);

    }
}


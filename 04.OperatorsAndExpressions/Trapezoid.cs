﻿using System;

class Trapezoid
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area=((a+b)/2)*h;
        Console.WriteLine("The area of Trapezoid is: "+area);
    }
}


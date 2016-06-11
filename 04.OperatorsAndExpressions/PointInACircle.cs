using System;

class PointInACircle
{
    static void Main()
    {
        do{
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool inCircle;
        double check = (x) * (x)+(y)*(y);
        double radius = 2 * 2;
        if (check<=radius )
        {
            inCircle = true;
        }
        else
        {
            inCircle = false;
        }
        Console.WriteLine(inCircle);
        }while(true);
    }
}


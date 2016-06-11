using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
       
        double radius=1.5*1.5;
        bool isInCircle=(x-1)*(x-1)+(y-1)*(y-1)<=radius;
        bool isOutsideRectangle=x>1||x<5&&y>-1||y<1;

        if (isInCircle && isOutsideRectangle)
        {
            Console.WriteLine("yes");
        }
        else 
        {
            Console.WriteLine("no");
        }


    }
}


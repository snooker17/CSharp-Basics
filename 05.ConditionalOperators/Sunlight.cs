using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';
        int UpperDots=n*3/2;
        int stars=1;
        int dots = 1;
        int middleDots = n / 2 + (n-2);


        Console.WriteLine("{0}{1}{0}",new string (dot,UpperDots),new string(star,stars),new string (dot,UpperDots));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string(dot, dots),new string(star,stars),
                new string(dot,middleDots),new string (star,stars),
                new string(dot,middleDots),new string (star,stars),
                new string(dot,dots));
            dots += 1;
            middleDots -= 1;

        }

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string(dot,n),new string(star,n));
        }

        Console.WriteLine("{0}",new string(star,n*3));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string(dot, n), new string(star, n));
        }

        dots -= 1;
        middleDots += 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string(dot, dots), new string(star, stars),
                new string(dot, middleDots), new string(star, stars),
                new string(dot, middleDots), new string(star, stars),
                new string(dot, dots));
           dots -= 1;
           middleDots += 1;

        }
        Console.WriteLine("{0}{1}{0}", new string(dot, UpperDots), new string(star, stars), new string(dot, UpperDots));




    }
}


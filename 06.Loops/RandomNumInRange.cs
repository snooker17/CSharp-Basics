using System;

class RandomNumInRange
{
    static void Main()
    {
        int randomNum=int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random r = new Random();

        for (int i = 0; i < randomNum; i++)
        {
            Console.Write(r.Next(min,max+1)+" ");
        }
        Console.WriteLine();
    }
}


using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int remainder = 2; 
        while (a != 0 || b != 0)
        {
            if (remainder == 0)
            {
                break;
            }
            remainder = a % b;
            a=b;
            b = remainder;
            
            
        }

        if (a==0)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
      
      
    }
}


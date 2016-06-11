using System;
using System.Numerics;
class TrailingZeros
{
    static void Main()
    {
        long n=long.Parse(Console.ReadLine());
        Console.WriteLine(countZerosInFactOf(n));
    }
   
    static int countZerosInFactOf(long n)
{   
    int result = 0;
    int  start = 1;
    while (n >= start)
    {
        start *= 5;
        result += (int)n/start; 
    }
    return result;
} 
}


using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter number to be tested:");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}


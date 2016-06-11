using System;

class DecimalToBinary
{
    static void Main()
    {
        long inputDec=long.Parse(Console.ReadLine());
        string remainder="";
        long num;

        while (inputDec>=1)
        {
            num = inputDec/2;
            remainder += (inputDec % 2).ToString();
            inputDec=num;
        }
        string buffer="";
        for (int i = remainder.Length-1; i >=0 ; i--)
        {
            buffer=buffer+remainder[i];
        }

        Console.Write(buffer);
        Console.WriteLine();
    }
}


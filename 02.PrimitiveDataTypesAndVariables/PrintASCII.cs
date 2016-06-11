using System;

class PrintASCII
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            Console.Write((char)(i)+",");

           
        }
        Console.WriteLine((char)(5));
    }
}

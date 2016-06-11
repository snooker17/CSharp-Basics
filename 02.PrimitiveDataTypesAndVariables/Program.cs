using System;

class Program
{
    static void Main()
    {
        
        string str = "Hello ";
        string str1 = "World!";
        object concat= str + str1;
        string wholeSentence = (string)concat;
        Console.WriteLine(wholeSentence);
    }
}


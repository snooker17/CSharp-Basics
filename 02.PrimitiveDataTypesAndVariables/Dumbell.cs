using System;

class Dumbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string emptyDumb = new string('.',n/2);
        string dumbbell = new string('&', n / 2 + 1);
        string emptyMiddle = new string('.',n);
        Console.WriteLine(emptyDumb+dumbbell+emptyMiddle+dumbbell+emptyDumb);

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string empty = new string('.', n / 2 - i - 1);
            string dumbellSec = '&' + new string('*', n / 2 + i) + '&';
            Console.WriteLine(empty+dumbellSec+emptyMiddle+dumbellSec+empty);
        }


        string bar=new string ('=',n);
        string middleBar = '&' + new string('*', n - 2) + '&';
        Console.WriteLine(middleBar+bar+middleBar);

        for (int i = n / 2 - 1; i > 0; i--)
        {
            string emptyDumbRev = new string('.',n/2-i);
            string dumbellSec = '&' + new string('*', n / 2 + i - 1) + '&';
            Console.WriteLine(emptyDumbRev+dumbellSec+emptyMiddle+dumbellSec+emptyDumbRev);
        }
        Console.WriteLine(emptyDumb + dumbbell + emptyMiddle + dumbbell + emptyDumb);
    }
}


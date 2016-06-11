using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthday = new DateTime ();

        Console.WriteLine("Enter your birthday in format(MM.DD.YYYY):");
       birthday=DateTime.Parse(Console.ReadLine());

       DateTime currentTime = DateTime.Now;
       Console.WriteLine("Now: "+(currentTime.Year-birthday.Year));
       Console.WriteLine("After 10 years: "+(currentTime.Year-birthday.Year+10));
    }
}


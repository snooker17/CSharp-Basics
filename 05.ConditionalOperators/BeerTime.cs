using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime myTime;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime stopTime = DateTime.Parse("3:00 AM");
        string dateString = Console.ReadLine();

        if (DateTime.TryParseExact(dateString, "h:mm tt", enUS, DateTimeStyles.None, out myTime))
        {
            if (myTime >= startTime || myTime <= stopTime)
            {
                Console.WriteLine("Beer Time!!!");
            }
            else
            {
                Console.WriteLine("Non beer Time!!!");
            }
        }
        else 
        {
            Console.WriteLine("Invalid input!!!");
        }
    }
}


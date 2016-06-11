using System;
using System.Globalization;
using System.Threading;
    class Program
    {
        static void Main()
        {
            CultureInfo enUS=new CultureInfo("en-US");
            DateTime myTime;
            DateTime startTime=DateTime.Parse("1:30 PM");
            DateTime stopTime=DateTime.Parse("3:00AM");
            string dateString=Console.ReadLine();

            if (DateTime.TryParseExact(dateString, "h:mm tt", enUS, DateTimeStyles.None, out myTime)) 
            {
                if (myTime>=startTime||myTime<=stopTime)
                {
                    Console.WriteLine("Beer TIME!!!");
                }
                else
                {
                    Console.WriteLine("non BEER TIME!!!");
                }
            }
        
            else
           	
                {
                    Console.WriteLine("invalid input!!!");
	            }
           	
	
    }
}

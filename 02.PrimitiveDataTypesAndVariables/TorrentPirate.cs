using System;

class TorrentPirate
{
    static void Main()
    {
        

        //Console.Write("Enter how much megabytes in total Jack should download: ");
        int downData = int.Parse(Console.ReadLine());
        bool check= ValidateDownData(downData);


      //  Console.WriteLine("Enter how much money would cost Jack to go to the cinema to watch one movie ");
        byte pricePerMovie = byte.Parse(Console.ReadLine());
        bool checkPrice = ValidatePriceCinema(pricePerMovie);

     //   Console.WriteLine("Enter how much money per hour does Jack’s wife spend: ");
        byte wifeCost = byte.Parse(Console.ReadLine());
        bool checkCost = ValidateWifeCost(wifeCost);

        if (check&&checkPrice&&checkCost)
        {

            EvaluateSituation(downData,pricePerMovie,wifeCost);
           
        }
        else Console.WriteLine("Wrong input data");
        Environment.Exit(0);
    }

    public static Boolean ValidateDownData(int downData)
    {
        if (downData < 0 || downData > 2147483647)
        {
            Console.WriteLine("Wrond input Data!!!");
            Console.WriteLine("Boundaries[0...2,147,483,647]");
            return false;
        }
        else return true;
    }

    public static Boolean ValidatePriceCinema(byte priceOfCinema)
    {
        if (priceOfCinema < 0 || priceOfCinema > 30)
        {
            Console.WriteLine("Wrond input Data!!!");
            Console.WriteLine("Boundaries[0...30]");
            return false;
        }
        else return true;
    }

    public static Boolean ValidateWifeCost(byte wifeCost)
    {
        if (wifeCost < 0 || wifeCost > 200)
        {
            Console.WriteLine("Wrond input Data!!!");
            Console.WriteLine("Boundaries[0...200]");
            return false;
        }
        else return true;
    }

    public static void EvaluateSituation(int downData,byte pricePerMovie,byte wifeCost){
        const byte internetSpeed=2;
        const byte seconds=60;
        const byte minutes=60;
        const short movieSize = 1500;

          double downTime = (double)downData / internetSpeed / seconds / minutes;
          double priceForDownload = (double)downTime * wifeCost;
          double numberOfMovies = (double)downData / movieSize;
          double cinemaPrice = (double)numberOfMovies * pricePerMovie;

          if (priceForDownload <= cinemaPrice)
          {
              Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
          }
          else
          {
              Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
          }
         
    }
}


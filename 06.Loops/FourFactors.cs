using System;

class Program
{
    static void Main()
    {
        uint fieldGoals=uint.Parse(Console.ReadLine());
        uint fieldGoalAttempts = uint.Parse(Console.ReadLine());
        uint pointFieldGoals = uint.Parse(Console.ReadLine());
        uint turnovers = uint.Parse(Console.ReadLine());
        uint offensiveRebounds = uint.Parse(Console.ReadLine());
        uint opponentDefensiveRebounds = uint.Parse(Console.ReadLine());
        uint freeThrows = uint.Parse(Console.ReadLine());
        uint freeThrowAttempts = uint.Parse(Console.ReadLine());


        double eFG = (double)(fieldGoals + 0.5 * pointFieldGoals) / fieldGoalAttempts;
        double TOV = (double)(turnovers / (fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers));
        double ORB = (double)offensiveRebounds/(offensiveRebounds+opponentDefensiveRebounds);
        double FT = (double)freeThrows / fieldGoalAttempts;

        Console.WriteLine("eFG% {0:F3}",eFG);
        Console.WriteLine("TOV% {0:F3}",TOV);
        Console.WriteLine("ORB% {0:F3}",ORB);
        Console.WriteLine("FT% {0:F3}",FT);
    }
}


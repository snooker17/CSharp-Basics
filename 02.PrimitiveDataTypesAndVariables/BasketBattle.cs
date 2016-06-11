using System;

class BasketBattle
{
    static void Main()
    {
        string first = Console.ReadLine();
        byte N = byte.Parse(Console.ReadLine());

        bool simeonFirst = false;
        bool nakovFirst = false;

        int nakovPoints = 0;
        int simeonPoints = 0;
        string winner = "";
        int winnerRound = 0;
        

        if (first == "Simeon")
        {
            simeonFirst = true;
        }
        else if (first == "Nakov")
        {
            nakovFirst = true;
        }

        for (int i = 1; i <=N; i++)
        {
            short firstPoints = short.Parse(Console.ReadLine());
            string firstSuccessShot = Console.ReadLine();

            if (simeonFirst)
            {
                if (firstSuccessShot == "success" && simeonPoints + firstPoints <= 500)
                {
                    simeonPoints += firstPoints;
                }
                if (simeonPoints == 500)
                {
                    winner = "Simeon";
                    winnerRound = i;
                    break;
                }
                
                short secondPoints = short.Parse(Console.ReadLine());
                string secondSuccessShot = Console.ReadLine();

                if (secondSuccessShot == "success" && nakovPoints + secondPoints <= 500)
                {
                    nakovPoints += secondPoints;

                    if (nakovPoints == 500)
                    {
                        winner = "Nakov";
                        winnerRound = i;
                        break;
                    }
                }
                
            }
            if (nakovFirst)
            {
                if (firstSuccessShot == "success" && nakovPoints + firstPoints <= 500)
                {
                    nakovPoints += firstPoints;
                }
                    if (nakovPoints == 500)
                    {
                        winner = "Nakov";
                        winnerRound = i;
                        break;
                    }
                
                short secondPoints = short.Parse(Console.ReadLine());
                string secondSuccessShot = Console.ReadLine();
                if (secondSuccessShot == "success" && simeonPoints + secondPoints <= 500)
                {
                    simeonPoints += secondPoints;

                    if (simeonPoints == 500)
                    {
                        winner = "Simeon";
                        winnerRound = i;
                        break;
                    }
                }

            }
            simeonFirst = !simeonFirst;
            nakovFirst = !nakovFirst;
        }
        if (winner == "Simeon")
        {
            Console.WriteLine(winner);
            Console.WriteLine(winnerRound);
            Console.WriteLine(nakovPoints);
        }
        else if (winner == "Nakov")
        {
            Console.WriteLine(winner);
            Console.WriteLine(winnerRound);
            Console.WriteLine(simeonPoints);
        }
        else if (winner == String.Empty && simeonPoints == nakovPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(simeonPoints);
        }
        else
        {
            if (simeonPoints > nakovPoints)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(simeonPoints - nakovPoints);
            }
            else
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(nakovPoints-simeonPoints);
            }
        }


        }
    
  
    }   
        
    


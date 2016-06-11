using System;

class BonusScore
{
    static void Main()
    {    
        int score = int.Parse(Console.ReadLine());
      
        switch (score)
        {
            case 1:
            case 2:
            case 3: score *= 10; break;
            case 4:
            case 5:
            case 6: score *= 100; break;
            case 7:
            case 8:
            case 9: score *= 1000; break;
            default: Console.WriteLine("Invalid Number!!!");
                break;
        }
        Console.WriteLine(score);
    
    }
}


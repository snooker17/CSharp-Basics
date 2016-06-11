using System;

class CheckForAPlayCard
{
    static void Main()
    {
        do
        {
            
        
         string score = (Console.ReadLine());
     
        switch (score)
        {
            case "2":
            case "3": 
            case "4":
            case "5":
            case "6": 
            case "7":
            case "8":
            case "9": 
            case "10":
            case "J":
            case "Q": 
            case "K":
            case "A":Console.WriteLine("YES!!!");break;
            default: Console.WriteLine("NO!!!"); break;
        }
        } while (true);
    
    }
}



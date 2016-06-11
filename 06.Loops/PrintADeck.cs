using System;

class PrintADeck
{
    static void Main(string[] args)
    {
        char[] characters = { '♣', '♦', '♥', '♠' };


        for (int i = 2; i < 15; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                { 
                    case 2: Console.Write("2{0} ",characters[j]); break;
                    case 3: Console.Write("3{0} ",characters[j]); break;
                    case 4: Console.Write("4{0} ",characters[j]); break;
                    case 5: Console.Write("5{0} ",characters[j]); break;
                    case 6: Console.Write("6{0} ",characters[j]); break;
                    case 7: Console.Write("7{0} ",characters[j]); break;
                    case 8: Console.Write("8{0} ",characters[j]); break;
                    case 9: Console.Write("9{0} ",characters[j]); break;
                    case 10: Console.Write("10{0} ",characters[j]); break;
                    case 11: Console.Write("J{0} ",characters[j]); break;
                    case 12: Console.Write("Q{0} ",characters[j]); break;
                    case 13: Console.Write("K{0} ",characters[j]); break;
                    case 14: Console.Write("A{0} ",characters[j]); break;
                    

                    default:
                        break;
                }
            }   
        }
        Console.WriteLine();
    }
}


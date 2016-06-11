using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();

        char[] numberHex = hexNum.ToCharArray(0,hexNum.Length);

        int[] number=new int[hexNum.Length];

        long result=0;

        for (int i = 0; i <numberHex.Length; i++)
        {
            switch (numberHex[i])
            {
                case '0': number[i] = 0; break;
                case '1': number[i] = 1; break;
                case '2': number[i] = 2; break;
                case '3': number[i] = 3; break;
                case '4': number[i] = 4; break;
                case '5': number[i] = 5; break;
                case '6': number[i] = 6; break;
                case '7': number[i] = 7; break;
                case '8': number[i] = 8; break;
                case '9': number[i] = 9; break;
               
                case 'A': number[i] = 10; break;
                case 'B': number[i] = 11; break;
                case 'C': number[i] = 12; break;
                case 'D': number[i] = 13; break;
                case 'E': number[i] = 14; break;
                case 'F': number[i] = 15; break;
                default:
                    break;
            }
           
        }

        Array.Reverse(number);
        for (int i = number.Length - 1; i >= 0; i--)
        {
           
                result += number[i]*(long)Math.Pow(16, i);
           
        }
        Console.WriteLine(result);
        Console.WriteLine();
    }
}


using System;

namespace _5.Problem__Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("a ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("b ");
            float secondNum = float.Parse(Console.ReadLine());
            Console.Write("c ");
            float thirdNum = float.Parse(Console.ReadLine());
            string binary = Convert.ToString(firstNum, 2).PadLeft(10, '0');           
            Console.WriteLine("result");
            Console.WriteLine("|{0,-10:X}|{1,10:D10}|{2,10:0.##}|{3,-10:F3}|", firstNum, binary, secondNum, thirdNum);
        }
    }
}

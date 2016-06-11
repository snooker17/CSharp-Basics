using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int option=int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: Console.WriteLine("Please enter int:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(++number);break;

            case 2: Console.WriteLine("Please enter double:");
                double doubleNum = double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleNum); break;

            case 3: Console.WriteLine("Please enter string:");
                string str1 = Console.ReadLine();
                Console.WriteLine(str1+"*"); break;
            default:Console.WriteLine("Wrong input!!!");break;
        }
    }
}


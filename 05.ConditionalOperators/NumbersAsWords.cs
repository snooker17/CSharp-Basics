using System;

class NumbersAsWords
{
    static void Main()
    {
                 
        int number = int.Parse(Console.ReadLine());

        int a = number / 100;
        int b = number / 10%10;
        int c = number % 100 % 10;

        string[] oneToNine = {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tenToTwenty= {"ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] elevenToTwelve = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };



        if (number >= 0 && number <= 9)
        {
            Console.WriteLine(UppercaseFirst(oneToNine[c]));
        }
       


        if (number >= 10 && number <= 99)
        {

            if (c == 0)
            {
                Console.WriteLine(UppercaseFirst(tenToTwenty[b - 1]));
            }

            else if (number >= 11 && number <= 19)
            {
                Console.WriteLine(UppercaseFirst(elevenToTwelve[c - 1]));
            }

            else
            {
                Console.WriteLine(UppercaseFirst(tenToTwenty[b - 1]) + " " + oneToNine[c]);
            }
        }


        if (number>=100&&number<=999)
        {
            if (b == 0 && c == 0)
            {
                Console.WriteLine(UppercaseFirst(oneToNine[a]) + " hundred");
            }

            else if (b == 0)
            {
                Console.WriteLine(UppercaseFirst(oneToNine[a]) + " hundred and " + oneToNine[c]);
            }

            else if (c == 0)
            {
                Console.WriteLine(UppercaseFirst(oneToNine[a]) + " hundred and " + tenToTwenty[b - 1]);
            }

            else if (number%100>=11&&number%100<=19)
            {
                Console.WriteLine(UppercaseFirst(oneToNine[a]) + " hundred and " + elevenToTwelve[c - 1]);
            }

            else
            {
                Console.WriteLine(UppercaseFirst(oneToNine[a]) + " hundred and " + tenToTwenty[b - 1] + " " + oneToNine[c]);
            }
        }
    }




    static string UppercaseFirst(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        char[] a = s.ToCharArray();
        a[0] = char.ToUpper(a[0]);
        return new string(a);
    }
}


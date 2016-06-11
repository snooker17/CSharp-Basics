using System;

class HexToDec
{
    static void Main()
    {
        long decnum = 0;
            int[] hexnum = new int[20];
            int i = 0, r;
            string num = "";
            decnum = long.Parse(Console.ReadLine());
            while (decnum != 0)
            {
                r =(int) decnum % 16;
                if (r < 10)
                {
                    r = r + 48;
                }
                else
                {
                    r = r + 55;
                }
                hexnum[i++] = r;
                decnum = decnum / 16;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                 num = num + (char)hexnum[j];
            }
            Console.WriteLine(num);
    }
}



using System;

class ZeroSubset
{
    static void Main()
    {
        int[]numbers=new int [5];

        int sum=0;
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        
        //For 2 elements
        for (int i = 0; i < 5; i++)
        {
            for ( int j=i+1; j < 5; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine(numbers[i]+" + "+numbers[j]+"= 0");
                    found = true;
                }
              
            }
        }
        
        //for 3 elements
        for (int i = 0; i < 3; i++)
        {
            for (int j = i+1; j < 4; j++)
            {
                for (int k = i+2; k < 5; k++)
                {
                    if (numbers[i]+numbers[j]+numbers[k]==0)
                    {
                        Console.WriteLine(numbers[i] + " + " + numbers[j] + " + "+ numbers[k]+" = 0");
                        found = true;
                    }
                }
            }
        }



        //for 4 elements
        for (int i = 0; i < 5; i++)
        {
            int sum1 = sum;
            if (sum1 - numbers[i] == 0)
            {
                if (i == 0)
                {
                    Console.WriteLine(numbers[1] + " + " + numbers[2] + " + " + numbers[3] + " + "+ numbers[4]+" =0");
                    found = true;
                }
                if (i == 1)
                {
                    Console.WriteLine(numbers[0] + " + " + numbers[2] + " + " + numbers[3] + " + " + numbers[4] + " =0");
                    found = true;
                }
                if (i == 2)
                {
                    Console.WriteLine(numbers[0] + " + " + numbers[1] + " + " + numbers[3] + " + " + numbers[4] + " =0");
                    found = true;
                }
                if (i == 3)
                {
                    Console.WriteLine(numbers[0] + " + " + numbers[1] + " + " + numbers[2] + " + " + numbers[4] + " =0");
                    found = true;
                }
                if (i == 4)
                {
                    Console.WriteLine(numbers[0] + " + " + numbers[1] + " + " + numbers[2] + " + " + numbers[3] + " =0");
                    found = true;
                }
            }
        }
        //for Five elements
        if (sum == 0)
        {
            Console.WriteLine(numbers[0] + " + " + numbers[1] + " + " + numbers[2] + " + " + numbers[3] +" + " +numbers[4] +" =0");
            found = true;
        }
        if (found == false)
        {
            Console.WriteLine("No zero subset");
        }

    }
}


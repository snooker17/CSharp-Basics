using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] numAsChars=input.ToCharArray(0,input.Length);
        int[] numbers = new int[numAsChars.Length];
        long numAsDecimal = 0; ;
        int numberSystem = 2;

        for (int i = 0; i < numAsChars.Length; i++)
        {
            numbers[i] = Convert.ToInt32(numAsChars[i]);
            if(numbers[i]==48){
                numbers[i]=0;
            }
            else
	{
                numbers[i]=1;
	}
            Console.WriteLine(numbers[i]);
        }
        Array.Reverse(numbers);
        for (int i = numbers.Length-1; i >=0; i--)
        {
            if (numbers[i]==1)
            {
                numAsDecimal +=(long) Math.Pow(numberSystem,i);
            }
        }
        Console.WriteLine(numAsDecimal);
    }
}


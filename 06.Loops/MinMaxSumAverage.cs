using System;

class MinMaxSumAverage
{
    static void Main(string[] args)
    {
        int howManyNumbers=int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------");
        int[] numbers = new int[howManyNumbers];
        int sum = 0;


        for (int i = 0; i < howManyNumbers; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        Console.WriteLine("min={0}",numbers[0]);
        Console.WriteLine("max={0}",numbers[howManyNumbers-1]);

        for (int i = 0; i < howManyNumbers; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("sum={0}",sum);
        double average = (double)sum / howManyNumbers;
        Console.WriteLine("avg={0:F2}",average);
    }
}


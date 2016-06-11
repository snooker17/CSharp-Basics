using System;

class OddAndEvenProduct
{
    static void Main()
    {

        string str = Console.ReadLine();

        string[] strArray=null;
        strArray=str.Split(' ');
        int[]  numbers=new int[strArray.Length];

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < strArray.Length; i++)
	        {
                numbers[i] = Convert.ToInt32(strArray[i]);
			}
      

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }

        if (oddProduct==evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = "+evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = "+oddProduct);
            Console.WriteLine("even_product = " + evenProduct);
        }
    }
}


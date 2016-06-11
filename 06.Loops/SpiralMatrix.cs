using System;
class SpiralMatrix
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int maxElement = n * n;
        int row = 0;
        int col = 0;
        int[,] matrix = new int[n, n];
        string direction= "right";


        for (int i = 1; i <= maxElement; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                row--;
                col++;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }
            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }

            if (direction == "down")
            {
                row++;
            }

            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
         
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}",matrix[i,j]);
            }
            Console.WriteLine();
        }
       



    }
}
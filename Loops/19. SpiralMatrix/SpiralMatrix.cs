using System;
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;

        if (n > 0 && n < 21)
        {
            while (value <= n * n)
            {
                while (col < spiralMatrix.GetLength(0) && spiralMatrix[col, row] == 0)
                {
                    spiralMatrix[row, col++] = value;
                    value++;
                }
                col--;
                row++;
                while (row < spiralMatrix.GetLength(1) && spiralMatrix[row, col] == 0)
                {
                    spiralMatrix[row++, col] = value;
                    value++;
                }
                row--;
                col--;
                while (col >= 0 && spiralMatrix[row, col] == 0)
                {
                    spiralMatrix[row, col--] = value;
                    value++;
                }
                col++;
                row--;
                while (row >= 0 && spiralMatrix[row, col] == 0)
                {
                    spiralMatrix[row--, col] = value;
                    value++;
                }
                col++;
                row++;
            }

            for (int i = 0; i < spiralMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < spiralMatrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", spiralMatrix[i, j]); 
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a integer between 1 and 20!");
        }
    }
}
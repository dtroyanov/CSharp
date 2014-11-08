using System;
class Palindromes
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int column = int.Parse(Console.ReadLine());
        string[,] matrix = new string[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int col = 0; col < column; col++)
            {
                Console.Write(matrix[i, col] = "" + (char)('a' + i) + (char)('a' + col + i) + (char)('a' + i) + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;
class DNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        char dot = '.';

        int dnaBlock = 7;
        int halfDna = 3;
        int sign = 0;
        int rowDna = 0;

        for (int row = 0; row < n; row++)
        {
            for (int i = 0; i < dnaBlock; i++)
            {
                if (i >= halfDna - sign && i <= halfDna + sign)
                {
                    Console.Write(letter);
                    if (letter == 'G')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                }
                else
                {
                    Console.Write(dot);
                }
            }
            if (rowDna >= halfDna)
            {
                sign--;
            }
            else
            {
                sign++;
            }
            rowDna++;
            if (rowDna == dnaBlock)
            {
                rowDna = 0;
                sign++;
            }
            Console.WriteLine();
        }
    }
}
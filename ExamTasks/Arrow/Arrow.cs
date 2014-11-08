using System;
class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char sharp = '#';
        char dots = '.';
        Console.WriteLine(new string(dots, n / 2) + new string(sharp, n) + new string(dots, n / 2));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string(dots, n / 2) + sharp + new string(dots, n - 2) + sharp + new string(dots, n / 2));
        }
        Console.WriteLine(new string(sharp, n / 2 + 1) + new string(dots, n - 2) + new string(sharp, n / 2 + 1));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string(dots, i + 1) + sharp + new string(dots, (2 * n - 5) - (2 * i)) + sharp + new string(dots, i + 1));
        }
        Console.WriteLine(new string(dots, n - 1) + sharp + new string(dots, n - 1));
    }
}
using System;
class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dots = '.';
        char stars = '*';
        Console.WriteLine(new string(dots, n / 2) + stars + new string(dots, n / 2));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dots, n / 2 - i - 1) + stars + new string(dots, 2 * i + 1) + stars + new string(dots , n / 2 - i - 1));
        }
        Console.WriteLine(new string(stars, n));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dots, n / 4) + stars + new string(dots, n - 2 - (n / 4) * 2) + stars + new string(dots, n / 4));
        }
        Console.WriteLine(new string(dots, n / 4) + new string(stars, n - (n / 4) * 2) + new string(dots, n / 4));
    }
}

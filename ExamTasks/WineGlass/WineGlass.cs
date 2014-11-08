using System;
class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dots = '.';
        char stars = '*';

        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine(new string(dots, i - 1) + "\\" + new string(stars, n - i * 2) + "/" + new string(dots, i - 1));
        }
        if (n < 12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string(dots, n / 2 - 1) + "||" + new string(dots, n / 2 - 1));
            }
            Console.WriteLine(new string('-', n));
        }
        else
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine(new string(dots, n / 2 - 1) + "||" + new string(dots, n / 2 - 1));
            }
            Console.WriteLine(new string('-', n));
            Console.WriteLine(new string('-', n));
        }
    }
}

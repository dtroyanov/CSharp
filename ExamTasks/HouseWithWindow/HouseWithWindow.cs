using System;
class HouseWithWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';

        Console.WriteLine(new string(dot, n - 1) + star + new string(dot, n - 1));
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string(dot, n - 2 - i) + star + new string(dot, 1 + 2 * i) + star + new string(dot, n - 2 - i));
        }
        Console.WriteLine(new string(star, 2 * n - 1));
        for (int i = 0; i < (n + 2) / 4; i++)
        {
            Console.WriteLine(star + new string(dot, n * 2 - 3) + star);
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(star + new string(dot, n / 2) + new string(star, n - 3) + new string(dot, n / 2) + star);
        }
        for (int i = 0; i < (n + 2) / 4; i++)
        {
            Console.WriteLine(star + new string(dot, n * 2 - 3) + star);
        }
        Console.WriteLine(new string(star, 2 * n - 1));
    }
}

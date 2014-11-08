using System;
class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        Console.WriteLine(new string(dot, n) + new string(star, n) + new string(dot, n));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dot, n - 1 - i) + star + new string(dot, n + 2 * i) + star + new string(dot, n - 1 - i));
        }
        Console.WriteLine(new string(star, n / 2 + 1) + new string(dot, n * 2 - 2) + new string(star, n / 2 + 1));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine(star + new string(dot, n * 3 - 2) + star);
        }
        Console.WriteLine(new string(star, 3 * n));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine(new string(dot, n / 2) + star + new string(dot, n / 2 - 1) + star + new string(dot, n - 2) + star + new string(dot, n / 2 - 1) + star + new string(dot, n /2));
        }
        Console.WriteLine(new string(dot, n / 2) + new string(star, n / 2 + 1) + new string(dot, n - 2) + new string(star, n / 2 + 1) + new string(dot, n / 2));
    }
}
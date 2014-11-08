using System;
class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';
        Console.WriteLine(new string(dot, n) + star + new string(dot, n));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dot, n - 1 - i) + star + new string(dot, 1 + 2 * i) + star + new string(dot, n - 1 -i));
        }
        Console.WriteLine(new string(star, n / 2 + 1) + new string(dot, n - 1) + new string(star, n / 2 + 1));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dot, 1 + i) + star + new string(dot, 2 * n - 3 - 2 * i) + star + new string(dot, 1 + i));
        }
        Console.WriteLine(new string(dot, n / 2) + star + new string(dot, n / 2 - 1) + star + new string(dot, n / 2 - 1) + star + new string(dot, n / 2));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dot, n / 2 - i - 1) + star + new string(dot, n / 2 - 1) + star + new string(dot, 1 + 2 * i) + star + new string(dot, n / 2 - 1) + star + new string(dot, n / 2 - i - 1));
        }
        Console.WriteLine(new string(star, n / 2 + 1) + new string(dot, n - 1) + new string(star, n / 2 + 1));
    }
}
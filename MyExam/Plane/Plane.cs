using System;
class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        

        Console.WriteLine(new string(dot, 3 * n / 2) + star + new string(dot, 3 * n / 2));
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine(new string(dot, 3 * n / 2 - 1 - i) + star + new string(dot, 1 + 2 * i) + star + new string(dot, 3 * n / 2 - 1 - i));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string(dot, n - 2 - 2 * i) + star + new string(dot, n + 2 + 4 * i) + star + new string(dot, n - 2 - 2 * i));
        }
        Console.WriteLine(star + new string(dot, n - 2) + star + new string(dot, n) + star + new string(dot, n - 2) + star);
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(star + new string(dot, n - 4 - 2 * i) + star + new string(dot, 1 + 2 * i) + star + new string(dot, n) + star + new string(dot, 1 + 2 * i) + star + new string(dot, n - 4 - 2 * i) + star);
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string(dot, n - 1 - i) + star + new string(dot, n + 2 * i) + star + new string(dot, n - 1 - i));
        }
        Console.WriteLine(new string(star, 3 * n));
    }
}

using System;
class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char slash = '/';
        char star = '*';
        char dash = '-';
        char space = ' ';

        Console.WriteLine(space + new string(star, n * 2 - 2) + new string(space, n + 1) + new string(star, n * 2 - 2) + space);
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(star + new string(slash, n * 2 - 2) + star + new string(space, n - 1) + star + new string(slash, n * 2 - 2) + star);
        }
        Console.WriteLine(star + new string(slash, n * 2 - 2) + star + new string(dash, n - 1) + star + new string(slash, n * 2 - 2) + star);
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(star + new string(slash, n * 2 - 2) + star + new string(space, n - 1) + star + new string(slash, n * 2 - 2) + star);
        }
        Console.WriteLine(space + new string(star, n * 2 - 2) + new string(space, n + 1) + new string(star, n * 2 - 2) + space);
    }
}

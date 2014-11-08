using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char slash = '/';
        char star = '*';
        char line = '|';
        char space = ' ';
        Console.WriteLine(new string(star, n * 2) + new string(space, n) + new string(star, n * 2));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(star + new string(slash, n * 2 - 2) + star + new string(space, n) + star + new string(slash, n * 2 - 2) + star);
        }
        Console.WriteLine(star + new string(slash, n * 2 - 2) + star + new string(line, n) + star + new string(slash, n * 2 - 2) + star);
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(star + new string(slash, n * 2 - 2) + star + new string(space, n) + star + new string(slash, n * 2 - 2) + star);
        }
        Console.WriteLine(new string(star, n * 2) + new string(space, n) + new string(star, n * 2));
    }
}
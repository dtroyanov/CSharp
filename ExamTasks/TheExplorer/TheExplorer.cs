using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '-';
        char star = '*';
        Console.WriteLine(new string(dash, n / 2) + star + new string(dash, n / 2));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string(dash, n / 2 - i - 1) + star + new string(dash, 1 + 2 * i) + star + new string(dash, n / 2 - i - 1));
        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string(dash, i + 1) + star + new string(dash, n - 4 - 2 * i) + star + new string(dash, i + 1));
        }
        Console.WriteLine(new string(dash, n / 2) + star + new string(dash, n / 2));
    }
}

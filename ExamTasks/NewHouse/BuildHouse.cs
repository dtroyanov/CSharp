using System;
class BuildHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2 + 1; i++)
        {
            string dash = new string('-', n / 2 - i);
            string stars = new string('*', 2 * i + 1);
            Console.WriteLine("{0}{1}{0}", dash, stars);
        }
        for (int i = 0; i < n; i++)
        {
            string pipe = new string('|', 1);
            string stars = new string('*', n - 2);
            Console.WriteLine("{0}{1}{0}", pipe, stars);
        }
    }
}
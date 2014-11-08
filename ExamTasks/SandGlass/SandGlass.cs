using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2 + 1; i++)
        {
            string dots = new string('.', i);
            string stars = new string('*', n - 2 * i);
            Console.WriteLine("{0}{1}{0}", dots, stars);
        }
        for (int i = 2; i <= n / 2 + 1; i++)
        {
            string dots = new string('.', n / 2 + 1 - i);
            string stars = new string('*', i * 2 - 1);
            Console.WriteLine("{0}{1}{0}", dots, stars);
        }
    }
}

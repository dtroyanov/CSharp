using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int p = 0;
            while (num != 0)
            {
                p <<= 1;
                p |= (num & 1);
                num >>= 1;
            }
            Console.WriteLine(p);
        }
    }
}
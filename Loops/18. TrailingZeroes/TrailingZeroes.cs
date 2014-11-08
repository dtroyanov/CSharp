using System;
using System.Numerics;
class TrailingZeroes
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int factor = 5;
        while (factor < n)
        {
            count += n / factor;
            factor *= 5;
        }
        Console.WriteLine(count);
    }
}

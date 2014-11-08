using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine(b);
        }
        else if (n == 3)
        {
            Console.WriteLine(c);
        }
        else
        {
            for (int i = 3; i < n; i++)
            {
                BigInteger sumT = a + b + c;
                a = b;
                b = c;
                c = sumT;
            }
            Console.WriteLine(c);
        }
    }
}

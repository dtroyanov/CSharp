using System;
using System.Numerics;
class Factoriel
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factoriel = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factoriel *= i;
        }
        Console.WriteLine(factoriel);
    }
}

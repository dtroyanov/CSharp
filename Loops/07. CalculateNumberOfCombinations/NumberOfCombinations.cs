using System;
using System.Numerics;
class NumberOfCombinations
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factoriel = 1;
        BigInteger factorielK = 1;
        BigInteger factorielNK = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factoriel *= i;
        }
        for (int i = 1; i <= (n-k); i++)
        {
            factorielNK *= i;
        }
        BigInteger result = factoriel / factorielNK;
        Console.WriteLine(result);
    }
}
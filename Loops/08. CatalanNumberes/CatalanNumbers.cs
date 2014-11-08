using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factoriel2n = 1;
        BigInteger factorielN = 1;
        BigInteger factorielN1 = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factoriel2n *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            factorielN1 *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
        }
        BigInteger result = factoriel2n / (factorielN1 * factorielN);
        Console.WriteLine(result);

        
    }
}
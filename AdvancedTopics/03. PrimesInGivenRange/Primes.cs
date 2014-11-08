using System;
using System.Collections.Generic;
class Primes
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        if (n > m)
        {
            Console.WriteLine("Empty list");
        }
        else
        {
            foreach (var prime in FindPrimeInRange(n, m))
            {
                Console.WriteLine(prime);
            }
        }
    }
    static List<int> FindPrimeInRange(int n, int m)
    {
        List<int> primes = new List<int>();
        if (n < 2)
        {
            n = 2;
        }
        for (int i = n; i <= m; i++)
        {
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(i);
            bool isPrime = true;
            while (divider <= maxDivider)
            {
                if (i % divider == 0)
                {
                    isPrime = false;
                    break;
                }
                divider++;
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }
        return primes;
    }
}

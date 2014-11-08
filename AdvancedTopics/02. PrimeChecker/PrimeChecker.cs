using System;
class PrimeChecker
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }
    static bool IsPrime(long n)
    {
        long divider = 2;
        long maxDivider = (long)(Math.Sqrt(n));
        bool isPrime = true;
        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            while (divider <= maxDivider)
            {
                if (n % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
        }
        return isPrime;
    }
}

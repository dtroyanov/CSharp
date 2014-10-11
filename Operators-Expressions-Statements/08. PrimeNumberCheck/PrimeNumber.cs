using System;
class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (num < 2)
        {
            isPrime = false;
        }
        else
        {
            int div = 2;
            int maxDiv = (int)Math.Sqrt(num);
            
            while (isPrime && (div <= maxDiv))
            {
                if (num % div == 0)
                {
                    isPrime = false;
                }
                div++;
            }
        }
        Console.WriteLine("Is prime? {0}", isPrime);
	}
}
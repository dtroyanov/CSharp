using System;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }
    static int Fib(int n)
    {
        int firstFib = 0;
        int secondFib = 1;
        for (int i = 0; i < n; i++)
        {
            int fib = firstFib + secondFib;
            firstFib = secondFib;
            secondFib = fib;
        }
        return secondFib;
    }
}

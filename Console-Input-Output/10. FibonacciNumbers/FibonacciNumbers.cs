using System;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int c = a;
                a = b;
                b = a + c;
            }
        }
    }
}

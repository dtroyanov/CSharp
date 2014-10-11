using System;
class ExchangeValues
{
    static void Main()
    {
        int a = 3;
        int b = 5;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        int c;

        c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange a = {0} and b = {1}", a, b);
    }
}
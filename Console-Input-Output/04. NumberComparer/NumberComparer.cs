using System;
class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal greater = Math.Max(a, b);
        Console.WriteLine("The bigger number is: {0}", greater);

    }
}
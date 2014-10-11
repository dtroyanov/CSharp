using System;
class Trapezoids
{
    static void Main()
    {
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("h = ");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}

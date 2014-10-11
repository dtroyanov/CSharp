using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - (4 * a * c);
        double firstX = (-(b) - Math.Sqrt(d)) / (2 * a);
        double secondX = (-(b) + Math.Sqrt(d)) / (2 * a);

        if (d < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (d == 0)
        {
            Console.WriteLine("X1 = X2 = {0}", firstX);
        }
        else
        {
            Console.WriteLine("X1 = {0}", firstX);
            Console.WriteLine("X2 = {0}", secondX);
        } 
    }
}

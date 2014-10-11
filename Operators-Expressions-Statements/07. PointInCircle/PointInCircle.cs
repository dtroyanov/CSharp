using System;
class PointInCircle
{
    static void Main()
    {
        Console.Write("x = ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("y = ");
        decimal y = decimal.Parse(Console.ReadLine());

        if (x * x + y * y <= 2 * 2)
        {
            Console.WriteLine("The coordinates are inside the circle");
        }
        else
        {
            Console.WriteLine("The coordinats aren't inside the circle");
        }
    }
}

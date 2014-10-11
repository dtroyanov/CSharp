using System;
class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("y = ");
        decimal y = decimal.Parse(Console.ReadLine());

        bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5m * 1.5m);
        bool outRect = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
        if (inCircle && !outRect)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

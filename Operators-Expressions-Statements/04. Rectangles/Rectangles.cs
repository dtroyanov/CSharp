using System;
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter the rectangle's width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the rectangle's height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle's perimeter is {0}.", 2*width + 2*height);
        Console.WriteLine("The rectangle's area is {0}.", width * height);
    }
}

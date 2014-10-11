using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = Math.PI * 2 * r;
        double area = Math.PI * r * r;

        Console.WriteLine("Perimter of the circle is {0:F2} and area is {1:F2}.", perimeter, area);
    }
}
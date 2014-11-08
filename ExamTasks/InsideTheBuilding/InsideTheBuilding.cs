using System;
class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine()); 
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine()); 
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        Console.WriteLine(isInside(x1, y1, h));
        Console.WriteLine(isInside(x2, y2, h));
        Console.WriteLine(isInside(x3, y3, h));
        Console.WriteLine(isInside(x4, y4, h));
        Console.WriteLine(isInside(x5, y5, h));
    }
    static string isInside(int x, int y, int h)
    {
        bool isInsideBottom = (x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h);
        bool isInsideTop = (x >= h) && (x <= h + h) && (y >= h) && (y <= 4 * h);
        bool inside = isInsideBottom | isInsideTop;
        string result = inside ? "inside" : "outside";
        return result;
    }
}

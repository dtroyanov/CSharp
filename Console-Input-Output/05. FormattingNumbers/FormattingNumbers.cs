using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)
        {
            Console.WriteLine("Enter a number between 0 and 500!");
        }
        Console.Write("Enter the first floating-point number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the second floating-point number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}

using System;
class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        if (Math.Abs(eps) > Math.Abs(a-b))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

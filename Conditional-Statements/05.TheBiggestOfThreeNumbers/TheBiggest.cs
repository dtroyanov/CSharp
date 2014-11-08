using System;
class TheBiggest
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
    }
}

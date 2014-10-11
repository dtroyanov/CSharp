using System;
class MoonGravitation
{
    static void Main()
    {
        Console.Write("Enter your weight: ");
        decimal weight = decimal.Parse(Console.ReadLine());
        

        Console.WriteLine("Your weight on the moon will be: {0}", weight * 0.17m);
    }
}
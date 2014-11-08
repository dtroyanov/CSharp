using System;
class RandomNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random generator = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(generator.Next(min, max + 1) + " ");
        }
    }
}

using System;
class TicTac
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        long value = 0;
        if (y == 0 && x == 0)
        {
            Console.WriteLine(value = v);
        }
        else if (y == 0 && x == 1)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 1, 2));
        }
        else if (y == 0 && x == 2)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 2, 3));
        }
        else if (y == 1 && x == 0)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 3, 4));
        }
        else if (y == 1 && x == 1)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 4, 5));
        }
        else if (y == 1 && x == 2)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 5, 6));
        }
        else if (y == 2 && x == 0)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 6, 7));
        }
        else if (y == 2 && x == 1)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 7, 8));
        }
        else if (y == 2 && x == 2)
        {
            Console.WriteLine(value = (long)Math.Pow(v + 8, 9));
        }
    }
}

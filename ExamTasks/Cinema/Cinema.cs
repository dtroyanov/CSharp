using System;
class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        decimal price = 0;
        if (projection == "Premiere")
        {
            price = rows * cols * 12;
            Console.WriteLine("{0:F2} leva", price);
        }
        else if (projection == "Normal")
        {
            price = rows * cols * 7.50m;
            Console.WriteLine("{0:F2} leva", price);
        }
        else if (projection == "Discount")
        {
            price = rows * cols * 5;
            Console.WriteLine("{0:F2} leva", price);
        }
    }
}

using System;
class BoxInBox
{
    static void Main()
    {
        int h1 = int.Parse(Console.ReadLine());
        int w1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        Check(h1, w1, d1, h2, w2, d2);
        Check(h1, w1, d1, h2, d2, w2);
        Check(h1, w1, d1, w2, h2, d2);
        Check(h1, w1, d1, w2, d2, h2);
        Check(h1, w1, d1, d2, w2, h2);
        Check(h1, w1, d1, d2, h2, w2);

        Check(h2, w2, d2, h1, w1, d1);
        Check(h2, w2, d2, h1, d1, w1); 
        Check(h2, w2, d2, w1, h1, d1);
        Check(h2, w2, d2, w1, d1, h1);
        Check(h2, w2, d2, d1, h1, w1);
        Check(h2, w2, d2, d1, w1, h1);
    }
    public static void Check(int h1, int w1, int d1, int h2, int w2, int d2)
    {
        if (h1 < h2 && w1 < w2 && d1 < d2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", h1, w1, d1, h2, w2, d2); 
        }
    }
}

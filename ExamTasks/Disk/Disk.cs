using System;
class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int lineX = n / 2;
        int lineY = n / 2;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int pointX = col - lineX;
                int pointY = row - lineY;

                double distanceToCenter = Math.Sqrt(pointX * pointX + pointY * pointY);
                bool isWithin = distanceToCenter <= r;
                if (isWithin)
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }
    }
}

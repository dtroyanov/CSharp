using System;
class CrossingSequences
{
    static void Main()
    {
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());
        int spiral = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int trib = 0;

        for (int i = 3; i <= 1000000; i++)
        {
           
            trib = t1 + t2 + t3;
            t1 = t2;
            t2 = t3;
            t3 = trib;
            if (trib > 1000000)
            {
                break;
            }
        }
        for (int i = 0; i <= 1000000; i++)
        {
            int sum = spiral + step;
            spiral = sum;
            if (spiral > 1000000)
            {
                break;
            }
        }
        for (int i = 1; i <= 1000000; i++)
        {
            if (spiral == t3)
            {
                Console.WriteLine(spiral);
                break;
            }
        }
    }
}
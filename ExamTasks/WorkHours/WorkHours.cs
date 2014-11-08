using System;
class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        decimal p = int.Parse(Console.ReadLine());
        decimal percentage = p / 100;
        decimal available = (((d - d * 0.10m) * 12) * percentage);
        int diff = h - (int)available;
        if (diff > 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(-diff);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(Math.Abs(diff));
        }
    }
}
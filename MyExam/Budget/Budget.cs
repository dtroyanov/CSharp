using System;
class Budget
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int weekends = (4 - h) * 2 * 20;
        int weekdays = (30 - p - 8) * 10;
        decimal goingOut = 10 + (0.03m * n);
        int totalAmount = weekdays + weekends + (p * (int)goingOut) + 150;
        if (totalAmount < n)
        {
            Console.WriteLine("Yes, leftover {0}.", n - totalAmount);
        }
        else if (totalAmount > n)
        {
            Console.WriteLine("No, not enough {0}.", totalAmount - n);
        }
        else if (totalAmount == n)
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}

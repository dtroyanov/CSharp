using System;
using System.Globalization;
class DiffBetweenDates
{
    static void Main()
    {
        CultureInfo bg = new CultureInfo("bg-BG");
        Console.Write("Enter first date(d.MM.yyyy format): ");
        DateTime first = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bg);
        Console.Write("Enter second date(d.MM.yyyy format): ");
        DateTime second = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bg);
        double diff = (second - first).TotalDays;
        Console.WriteLine("The difference between these two dates in days is: {0}", diff);
    }
}

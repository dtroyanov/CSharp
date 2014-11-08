using System;
using System.Globalization;
using System.Threading;
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time(hh:mm tt): ");
        string time = Console.ReadLine();
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");
        DateTime beerTime;

        if (DateTime.TryParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out beerTime))
        {
            if (beerTime >= start || beerTime < end)
            {
                Console.WriteLine("Beer time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid time!");
        }
    }
}

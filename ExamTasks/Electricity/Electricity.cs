using System;
class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());

        if (time.Hour >= 0 && time.Hour < 9)
        {
            double consumption = (100.53 + 8 * 125.9);
            int electricity = (int)(floors * flats * consumption);
            Console.WriteLine("{0} watts", electricity);
        }
        else if (time.Hour >= 14 && time.Hour < 19)
        {
            double consumption = (2 * 100.53 + 2 * 125.9);
            int electricity = (int)(floors * flats * consumption);
            Console.WriteLine("{0} watts", electricity);
        }
        else if (time.Hour >= 19 && time.Hour <= 23)
        {
            double consumption = (7 * 100.53 + 6 * 125.9);
            int electricity = (int)(floors * flats * consumption);
            Console.WriteLine("{0} watts", electricity);
        }
        else
        {
            Console.WriteLine("0 watts");
        }
    }
}

using System;
class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        decimal p = int.Parse(Console.ReadLine());
        decimal h = int.Parse(Console.ReadLine());

        decimal weekend = (48 - h) * 3 / 4;
        decimal holidays = p * 2 / 3;

        decimal days = weekend + holidays + h;

        if (leap == "leap")
        {
            Console.WriteLine((int)(days + days * 0.15m));
        }
        else
        {
            Console.WriteLine((int)days);
        }
        
    }
}
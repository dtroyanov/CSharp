using System;
class Football
{
    static void Main()
    {
        string leap = Console.ReadLine();
        decimal p = int.Parse(Console.ReadLine());
        decimal h = int.Parse(Console.ReadLine());
        decimal weekends = (52 - h) / 3;
        decimal holidays = p / 2;
        if (leap == "f")
        {
            int output = (int)(weekends * 2 + h + holidays);
            Console.WriteLine(output);
        }
        else
        {
            int output = (int)(weekends * 2 + h + holidays + 3);
            Console.WriteLine(output);
        }
    }
}

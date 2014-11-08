using System;
class ExamSchedule
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int examHours = int.Parse(Console.ReadLine());
        int examMin = int.Parse(Console.ReadLine());
        if (partOfDay == "PM")
        {
            hour += 12;
            if (hour == 24)
            {
                hour = 0;
            }
        }
        DateTime start = new DateTime(2014, 11, 01, hour, minutes, 0);
        DateTime end = start.AddHours(examHours).AddMinutes(examMin);
        Console.WriteLine("{0:hh:mm:tt}", end);
    }
}

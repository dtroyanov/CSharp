using System;
class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birth date: ");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        TimeSpan myAge = now - birthDay;
        int age = (int)((myAge.TotalDays) / 365.25);

        Console.WriteLine(age);

        Console.WriteLine("After 10 years I'll be {0} years old", age + 10);
    }
}
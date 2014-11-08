using System;
class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int cables = 0;
        for (int i = 0; i < n; i++)
        {
            int lenght = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                lenght *= 100;
            }
            if (lenght >= 20)
            {
                sum += lenght;
                cables++;
            }
        }
        sum = sum - 3 * (cables - 1);
        int cablesNum = sum / 504;
        int remainder = sum % 504;
        Console.WriteLine(cablesNum);
        Console.WriteLine(remainder);
    }
}
using System;
class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a new number: ");
            int num = int.Parse(Console.ReadLine());

            min = Math.Min(min, num);
            max = Math.Max(max, num);
            sum += num;
            avg = sum / n;
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(sum);
        Console.WriteLine("{0:F2}", avg);
    }
}

using System;
class Sum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            double a = double.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}

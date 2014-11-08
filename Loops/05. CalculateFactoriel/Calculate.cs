using System;
class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double s = 1;
        double f = 1;
        for (int i = 1; i <= n; i++)
        {
            f *= i;
            int power = (int)Math.Pow(x, i);
            s = s + f / power;
        }
        Console.WriteLine("{0:F5}", s);
    }
}

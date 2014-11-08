using System;
class GCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Greatest common divider is {0}", b);
        }
        else if (b == 0)
        {
            Console.WriteLine("Greatest common divider is {0}", a);
        }
        else if (a > b)
        {
            int remainder = b;
            while (remainder > 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            Console.WriteLine("Greatest common divider is {0}", a);
        }
        else if (b > a)
        {
            int remainder = a;
            while (remainder > 0)
            {
                remainder = b % a;
                b = a;
                a = remainder;
            }
            Console.WriteLine("Greatest common divider is {0}", b);
        }
    }
}
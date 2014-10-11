using System;
class BitExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = uint.Parse(Console.ReadLine());

        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        if (Math.Max(p, q) + k > 32)

        {
            Console.WriteLine("Out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            int counter = q;
            for (int i = p;i<=p+k-1;i++)
            {
                long mask = 1;
                long firstBits = ((mask << i) & number) >> i;
                long secondBits = ((mask << counter) & number) >> counter;
                number = number & ~(mask << i);
                number = number & ~(mask << counter);
                number = number | (secondBits << i);
                number = number | (firstBits << counter);
                counter++;
            }
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32,'0'));
        }
    }
}

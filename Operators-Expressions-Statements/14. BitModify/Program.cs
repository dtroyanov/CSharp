using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value(0 or 1): ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
        if (value == 1)
        {
            int mask = 1 << pos;
            int check = mask | num;
            Console.WriteLine(check);
            Console.WriteLine(Convert.ToString(check, 2).PadLeft(16, '0'));
        }
        else
        {
            int newMask = ~(1 << pos);
            int newCheck = newMask & num;
            Console.WriteLine(newCheck);
            Console.WriteLine(Convert.ToString(newCheck, 2).PadLeft(16, '0'));
        }
    }
}

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        long num = long.Parse(Console.ReadLine());

        string binary = null;
        int remainder;
        if (num == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            while (num > 0)
            {

                remainder = (int)num % 2;
                num = num / 2;
                binary = remainder + binary;
            }
            Console.WriteLine(binary);
        }
    }
}

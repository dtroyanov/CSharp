using System;
class BitCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = num >> position;
        int check = mask & 1;

        if (check == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        Console.WriteLine(Convert.ToString(num, 2));
    }
}
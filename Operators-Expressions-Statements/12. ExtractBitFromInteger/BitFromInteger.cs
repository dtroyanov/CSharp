using System;
class BitFromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index: ");
        int index = int.Parse(Console.ReadLine());

        int mask = 1 << index;
        int check = mask & num;
        if (check == 0)
        {
            Console.WriteLine("The bit of index {0} is 0", index);
        }
        else
        {
            Console.WriteLine("The bit of index {0} is 1", index);
        }
    }
}
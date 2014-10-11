using System;
class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint check = num & mask;

        if (check == 0)
        {
            Console.WriteLine("#3 bit is 0.");
        }
        else
        {
            Console.WriteLine("#3 bit is 1.");
        }
    }
}

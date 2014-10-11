using System;
class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("This is the binary representation of this number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        uint mask = ((7 << 3) | (7 << 24));
        uint firstGroup = (number >> 3) & 7;
        uint secondGroup = (number >> 24) & 7;
        uint newNumber = (number & (~mask)) | ((firstGroup << 24) | (secondGroup << 3));
        Console.WriteLine(newNumber);
        Console.WriteLine("This is the binary representation of the new number: {0}", Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}

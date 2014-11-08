using System;
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long num = long.Parse(Console.ReadLine());

        string hex = null;
        long digit;
        while (num > 0)
        {
            digit = num % 16;
            num = num / 16;
            switch (digit)
            {
                case 10: 
                    hex = 'A' + hex; 
                    break;
                case 11:
                    hex = 'B' + hex;
                    break;
                case 12:
                    hex = 'C' + hex;
                    break;
                case 13:
                    hex = 'D' + hex;
                    break;
                case 14:
                    hex = 'E' + hex;
                    break;
                case 15:
                    hex = 'F' + hex;
                    break;
                default:
                    hex = digit + hex;
                    break;
            }
        }
        Console.WriteLine(hex);
    }
}

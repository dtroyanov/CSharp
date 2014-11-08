using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine();
        long result = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '1':
                    result = result + 1 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '2':
                    result = result + 2 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '3':
                    result = result + 3 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '4':
                    result = result + 4 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '5':
                    result = result + 5 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '6':
                    result = result + 6 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '7':
                    result = result + 7 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '8':
                    result = result + 8 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case '9':
                    result = result + 9 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case 'A': 
                    result = result + 10 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case 'B':
                    result = result + 11 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case 'C':
                    result = result + 12 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case 'D':
                    result = result + 13 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case 'E':
                    result = result + 14 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                case 'F':
                    result = result + 15 * (long)Math.Pow(16, (hex.Length - i - 1));
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(result);
    }
}
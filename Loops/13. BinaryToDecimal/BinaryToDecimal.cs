using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary integer: ");
        string binary = Console.ReadLine();

        long result = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }
            result += (long)Math.Pow(2, i);
        }
        Console.WriteLine(result);
    }
}

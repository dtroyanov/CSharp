using System;
class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        
        string odd = "";
        string even = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                odd += input[i];
            }
            else
            {
                even += input[i];
            }
        }
        ulong oddSum = 0;
        for (int i = 0; i < odd.Length; i++)
        {
            if ((i + 1) % oddJump == 0)
            {
                oddSum *= odd[i];
            }
            else
            {
                oddSum += odd[i];
            }
        }
        ulong evenSum = 0;
        for (int i = 0; i < even.Length; i++)
        {
            if ((i + 1) % evenJump == 0)
            {
                evenSum *= even[i];
            }
            else
            {
                evenSum += even[i];
            }
        }
        string oddHex = oddSum.ToString("X");
        string evenHex = evenSum.ToString("X");
        Console.WriteLine("Odd: {0}", oddHex);
        Console.WriteLine("Even: {0}", evenHex);
    }
}

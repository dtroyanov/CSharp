using System;
class CarNumbers
{
    static int count = 0;
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        for (int x = 0; x < letters.Length; x++)
        {
            for (int y = 0; y < letters.Length; y++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    CheckNumber("CA" + a + a + a + a + letters[x] + letters[y], sum);
                    for (int b = 0; b <= 9; b++)
                    {
                        if (b != a)
                        {
                            CheckNumber("CA" + a + b + b + b + letters[x] + letters[y], sum);
                            CheckNumber("CA" + a + a + a + b + letters[x] + letters[y], sum);
                            CheckNumber("CA" + a + b + a + b + letters[x] + letters[y], sum);
                            CheckNumber("CA" + a + a + b + b + letters[x] + letters[y], sum);
                            CheckNumber("CA" + a + b + b + a + letters[x] + letters[y], sum);
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
    static void CheckNumber(string carNumber, int magicSum)
    {
        int weight = 0;
        foreach (var ch in carNumber)
        {
            if (ch >= '0' && ch <= '9')
            {
                weight += (ch - '0');
            }
            else
            {
                weight += (10 * (ch - 'A' + 1));
            }
        }
        if (weight == magicSum)
        {
            count++;
        }
    }
}
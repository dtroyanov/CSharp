using System;
class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int left = 0;
        int right = 0;
        int vertical = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int bit = 0; bit < 32; bit++)
            {
                int first = numbers[i];
                int second = numbers[i + 1];
                int mask = 1 << bit;
                bool check = (first & mask) > 0;

                if (check && (second & (mask << 1)) > 0)
                {
                    left++;
                }
                if (check && (second & (mask >> 1)) > 0)
                {
                    right++;
                }
                if (check && (second & mask) > 0)
                {
                    vertical++;
                }
            }
        }
        Console.WriteLine(right);
        Console.WriteLine(left);
        Console.WriteLine(vertical);
    }
}

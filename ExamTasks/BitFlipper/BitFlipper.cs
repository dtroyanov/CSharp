using System;
class BitFlipper
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int lastBit = 62;

        while (lastBit > 0)
        {
            lastBit--;
            ulong trioBits = (n >> lastBit) & 7;
            if (trioBits == 0 || trioBits == 7)
            {
                n = n ^ ((ulong)7 << lastBit);
                lastBit -= 2;
            }
        }
        Console.WriteLine(n);
    }
}
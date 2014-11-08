using System;
class ChangeEvenBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        ulong l = ulong.Parse(Console.ReadLine());
        ulong one = 1;
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int len = 0;
            do
            {
                nums[i] /= 2;
                len++;
            } while (nums[i] > 0);
            int position = 0;
            while (len > 0)
            {
                ulong mask = one << position;
                if ((l & mask) == 0)
                {
                    counter++;
                }
                l = l | mask;
                position += 2;
                len--;
            }
        }
        Console.WriteLine(l);
        Console.WriteLine(counter);
    }
}

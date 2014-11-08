using System;
class SumOfElements
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] numbers = n.Split();
        long maxNum = long.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            long max = long.Parse(numbers[i]);
            if (max > maxNum)
            {
                maxNum = max;
            }
        }
        long[] nums = new long[numbers.Length];
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = long.Parse(numbers[i]);
            sum += nums[i];
        }
        if ((sum - maxNum) == maxNum)
        {
            Console.WriteLine("Yes, sum={0}", maxNum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(maxNum - (sum - maxNum)));
        }
    }
}
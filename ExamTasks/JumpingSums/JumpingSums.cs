using System;
class JumpingSums
{
    static void Main()
    {
        string s = Console.ReadLine();
        int jumps = int.Parse(Console.ReadLine());
        string[] nums = s.Split();
        int[] numbers = new int[nums.Length];
        int length = numbers.Length;
        int maxSum = 0;
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(nums[i]);
        }
        for (int i = 0; i < length; i++)
        {
            int value = numbers[i];
            int currIndex = i;
            int nextIndex = (value + currIndex) % length;
            int sum = value;
            for (int j = 0; j < jumps; j++)
            {
                
                value = numbers[nextIndex];
                currIndex = nextIndex;
                nextIndex = (value + currIndex) % length;
                sum += value;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}
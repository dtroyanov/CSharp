using System;
class Pairs
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] nums = n.Split();
        int[] numbers = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = int.Parse(nums[i]);
        }
        int maxDiff = 0;
        int firstValue = numbers[0] + numbers[1];
        
        for (int i = 2; i < numbers.Length - 1; i+=2)
        {
            int nextValue = numbers[i] + numbers[i + 1];
            int diff = Math.Abs(nextValue - firstValue);
            maxDiff = Math.Max(diff, maxDiff);
            firstValue = nextValue;
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", firstValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}

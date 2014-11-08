using System;
class SequenceOfKNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
        input = input + " " + int.MaxValue;
        string[] numbers = input.Split();
        int count = 1;
        int prev = int.Parse(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num == prev)
            {
                count++;
            }
            else
            {
                for (int counter = 0; counter < count % k; counter++)
                {
                    Console.Write(prev + " ");
                }
                count = 1;
            }
            prev = num;
        }
    }
}

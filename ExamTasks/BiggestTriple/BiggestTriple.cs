using System;
class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        int index = 0;
        int maxSum = 0;
        int first = 0;
        for (index = 0; index < numbers.Length; index++)
        {
            int num1 = int.Parse(numbers[index]);
            int num2 = 0;
            if (index + 1 < numbers.Length)
            {
                num2 = int.Parse(numbers[index + 1]);
            }
            int num3 = 0;
            if (index + 2 < numbers.Length)
            {
                num3 = int.Parse(numbers[index + 2]);
            }
            int sum = num1 + num2 + num3;
            if (sum > maxSum)
            {
                maxSum = sum;
                first = index;
            }
            index += 2;
        }
        for (int i = first; i < first + 3; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}

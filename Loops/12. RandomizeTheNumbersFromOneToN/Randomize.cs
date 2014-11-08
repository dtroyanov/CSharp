using System;
class Randomize
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random generator = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }
        foreach (var i in numbers)
        {
            int num = generator.Next(0, n);
            int newNum = numbers[num];
            numbers[num] = numbers[0];
            numbers[0] = newNum;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}

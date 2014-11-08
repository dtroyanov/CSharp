using System;
class SortingNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(num);
        foreach (int number in num)
        {
            Console.WriteLine(number);
        }
    }
}

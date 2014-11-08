using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int secondSum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            secondSum += num;
        }
        if (secondSum == sum)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum - secondSum));
        }
    }
}

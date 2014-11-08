using System;
using System.Collections.Generic;
using System.Linq;
class OddEven
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        string nums = Console.ReadLine();
        string[] numbers = nums.Split();
        if (nums == "")
        {
            numbers = new string[0];
        }
        List<decimal> odd = new List<decimal>();
        List<decimal> even = new List<decimal>();

        for (int i = 0; i < numbers.Length; i++)
        {
            decimal element = decimal.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                odd.Add(element);
            }
            else
            {
                even.Add(element);
            }
        }
        decimal min;
        decimal max;
        decimal sum;
        decimal min2;
        decimal max2;
        decimal sum2;
        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length == 1)
        {
            min = odd.Min();
            max = odd.Max();
            sum = odd.Sum();

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)sum, (double)min, (double)max);
        }
        else
        {
            min = odd.Min();
            max = odd.Max();
            sum = odd.Sum();
            min2 = even.Min();
            max2 = even.Max();
            sum2 = even.Sum();
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)sum, (double)min, (double)max, (double)sum2, (double)min2, (double)max2);
        }
    }
}
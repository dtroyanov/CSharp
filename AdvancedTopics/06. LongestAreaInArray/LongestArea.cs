using System;
using System.Collections.Generic;
using System.Linq;
class LongestArea
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        string[] str = new string[n];
        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
        }
        int count = 1;
        int countMax = 1;
        int element = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                count++;
                if (count > countMax)
                {
                    countMax = count;
                    element = (i + 1) - (countMax - 1);
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(countMax);
        for (int i = 0; i < countMax; i++)
        {
            Console.WriteLine(str[element + i]);
        }
    }
}
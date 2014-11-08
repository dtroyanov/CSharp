﻿using System;
class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        for (int i = 0; i < numbers.Length - 2; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                bool first = ((numbers[i] >> j) & 7) == 5;
                bool second = ((numbers[i + 1] >> j) & 7) == 2;
                bool third = ((numbers[i + 2] >> j) & 7) == 5;
                if (first && second && third)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

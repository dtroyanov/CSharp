﻿using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine()); 
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product of these these three numbers is 0.");
        }
        else if (a > 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("The product of these these three numbers is with sign +.");
                }
                else
                {
                    Console.WriteLine("The product of these these three numbers is with sign -.");
                }
            }
            else
            {
                if (c > 0)
                {
                    Console.WriteLine("The product of these these three numbers is with sign -.");
                }
                else
                {
                    Console.WriteLine("The product of these these three numbers is with sign +.");
                }
            }
        }
        else if (a < 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("The product of these these three numbers is with sign -.");
                }
                else
                {
                    Console.WriteLine("The product of these these three numbers is with sign +.");
                }
            }
            else
            {
                if (c > 0)
                {
                    Console.WriteLine("The product of these these three numbers is with sign +.");
                }
                else
                {
                    Console.WriteLine("The product of these these three numbers is with sign -.");
                }
            }
        }
    }
}
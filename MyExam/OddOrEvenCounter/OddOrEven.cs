using System;
class OddOrEven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int evenCounter = 0;
        int oddCounter = 0;
        int maxOddCounter = 0;
        int maxEvenCounter = 0;
        int set = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (s == "odd")
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0)
                    {
                        oddCounter++;
                        if (oddCounter > maxOddCounter)
                        {
                            maxOddCounter = oddCounter;
                            set = i;
                        }
                    }
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        evenCounter++;
                        if (evenCounter > maxEvenCounter)
                        {
                            maxEvenCounter = evenCounter;
                            set = i;
                        }
                    }
                }
            }
            evenCounter = 0;
            oddCounter = 0;
        }
        if (s == "odd")
        {
            if (maxOddCounter == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                switch (set)
                {
                    case 1: Console.WriteLine("First set has the most odd numbers: {0}", maxOddCounter); break;
                    case 2: Console.WriteLine("Second set has the most odd numbers: {0}", maxOddCounter); break;
                    case 3: Console.WriteLine("Third set has the most odd numbers: {0}", maxOddCounter); break;
                    case 4: Console.WriteLine("Fourth set has the most odd numbers: {0}", maxOddCounter); break;
                    case 5: Console.WriteLine("Fifth set has the most odd numbers: {0}", maxOddCounter); break;
                    case 6: Console.WriteLine("Sixth set has the most odd numbers: {0}", maxOddCounter); break;
                    case 7: Console.WriteLine("Seventh set has the most odd numbers: {0}", maxOddCounter); break;
                    case 8: Console.WriteLine("Eighth set has the most odd numbers: {0}", maxOddCounter); break;
                    case 9: Console.WriteLine("Ninth set has the most odd numbers: {0}", maxOddCounter); break;
                    case 10: Console.WriteLine("Tenth set has the most odd numbers: {0}", maxOddCounter); break;
                    default:
                        break;
                }
            }
        }
        else
        {
            if (maxEvenCounter == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                switch (set)
                {
                    case 1: Console.WriteLine("First set has the most even numbers: {0}", maxEvenCounter); break;
                    case 2: Console.WriteLine("Second set has the most even numbers: {0}", maxEvenCounter); break;
                    case 3: Console.WriteLine("Third set has the most even numbers: {0}", maxEvenCounter); break;
                    case 4: Console.WriteLine("Fourth set has the most even numbers: {0}", maxEvenCounter); break;
                    case 5: Console.WriteLine("Fifth set has the most even numbers: {0}", maxEvenCounter); break;
                    case 6: Console.WriteLine("Sixth set has the most even numbers: {0}", maxEvenCounter); break;
                    case 7: Console.WriteLine("Seventh set has the most even numbers: {0}", maxEvenCounter); break;
                    case 8: Console.WriteLine("Eighth set has the most even numbers: {0}", maxEvenCounter); break;
                    case 9: Console.WriteLine("Ninth set has the most even numbers: {0}", maxEvenCounter); break;
                    case 10: Console.WriteLine("Tenth set has the most even numbers: {0}", maxEvenCounter); break;
                    default:
                        break;
                }
            }
        }
    }
}
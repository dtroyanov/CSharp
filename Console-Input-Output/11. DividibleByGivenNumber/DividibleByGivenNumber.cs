using System;
class DividibleByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
                p++;
            }
        }
        Console.WriteLine("There are {0} numbers between {1} and {2}.", p, start, end);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.Write("Enter few names: ");
        string firstList = Console.ReadLine();
        Console.Write("Enter another few names: ");
        string secondList = Console.ReadLine();
        string[] firstNames = firstList.Split();
        string[] secondNames = secondList.Split();
        List<string> first = firstNames.ToList<string>();
        List<string> second = secondNames.ToList<string>();
        for (int i = 0; i < first.Count; i++)
        {
            for (int j = 0; j < second.Count; j++)
            {
                if (first.Contains(second[j]))
                {
                    first.Remove(second[j]);
                }
            }
        }
        foreach (string name in first)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}

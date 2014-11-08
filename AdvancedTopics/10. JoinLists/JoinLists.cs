using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        Console.Write("Enter few numbers: ");
        string firstNums = Console.ReadLine();
        string[] first = firstNums.Split();
        Console.Write("Enter few numbers: ");
        string secondNums = Console.ReadLine();
        string[] second = secondNums.Split();

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();
        for (int i = 0; i < first.Length; i++)
        {
            firstList.Add(int.Parse(first[i]));
        }
        for (int i = 0; i < second.Length; i++)
        {
            firstList.Add(int.Parse(second[i]));
        }
        firstList.Sort();
        secondList = firstList.Distinct().ToList();
        foreach (var item in secondList)
        {
            Console.Write(item + " ");
        }
    }
}

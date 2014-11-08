using System;
using System.Collections.Generic;
class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] names = input.Split();
        List<string> list = new List<string>();
        for (int i = 0; i < names.Length; i++)
        {
            list.Add(names[i]);
        }
        list.Sort();
        int counter = 1;
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == list[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", list[i - 1], counter);
                counter = 1;
            }

            if (i == list.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", list[i], counter);
            }
        }
    }
}
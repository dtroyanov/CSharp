using System;
using System.Collections.Generic;
class WeirdCombinations
{
    static void Main()
    {
        string s = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string result = "";
        char[] chars = new char[5];
        for (int i = 0; i < s.Length; i++)
        {
            chars[i] = s[i];
        }
        List<string> list = new List<string>();
        for (int first = 0; first < chars.Length; first++)
        {
            for (int second = 0; second < chars.Length; second++)
            {
                for (int third = 0; third < chars.Length; third++)
                {
                    for (int fourth = 0; fourth < chars.Length; fourth++)
                    {
                        for (int fifth = 0; fifth < chars.Length; fifth++)
                        {
                            result = "" + chars[first] + chars[second] + chars[third] + chars[fourth] + chars[fifth];
                            list.Add(result);
                        }
                    }
                }
            }
        }
        string check = "";
        for (int i = 0; i < list.Count; i++)
        {
            if (n == i)
            {
                check = list[i];
            }
        }
        if (n >= list.Count)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(check);
        }
    }
}
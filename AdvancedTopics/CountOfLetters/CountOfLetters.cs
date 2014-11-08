using System;
using System.Collections.Generic;
class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] letters = input.Split();
        List<char> charList = new List<char>();
        for (int i = 0; i < letters.Length; i++)
        {
            charList.Add(Convert.ToChar(letters[i]));
        }
        charList.Sort();
        int counter = 1;
        for (int i = 1; i < charList.Count; i++)
        {
            if (charList[i] == charList[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", charList[i - 1], counter);
                counter = 1;
            }
            if (i == charList.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", charList[i], counter);
            }
        }
    }
}
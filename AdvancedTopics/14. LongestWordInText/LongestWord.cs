using System;
class LongestWord
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', ':', ';', '.' });
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > words[counter].Length)
            {
                counter = i;
            }
        }
        Console.WriteLine(words[counter]);
    }
}

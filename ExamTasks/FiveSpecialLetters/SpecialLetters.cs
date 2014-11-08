using System;
class SpecialLetters
{
    public static void Main()
    {
        long start = long.Parse(Console.ReadLine());
        long end = long.Parse(Console.ReadLine());
        int count = 0;

        for (char first = 'a'; first <= 'e'; first++)
        {
            for (char second = 'a'; second <= 'e'; second++)
            {
                for (char third = 'a'; third <= 'e'; third++)
                {
                    for (char forth = 'a'; forth <= 'e'; forth++)
                    {
                        for (char fifth = 'a'; fifth <= 'e'; fifth++)
                        {
                            string word = "" + first + second + third + forth + fifth;
                            long weight = CalcWeight(word);
                            if (weight >= start && weight <= end)
                            {
                                if (count > 0)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(word);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
    static long CalcWeight(string word)
    {
        bool[] used = new bool[(int)'e' + 1];
        long weight = 0;
        int index = 1;
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if (!used[letter])
            {
                weight += index * LetterValue(letter);
                index++;
                used[letter] = true;
            }
        }
        return weight;
    }
    static int LetterValue(char letter)
    {
        switch (letter)
        {
            case 'a': return 5;
            case 'b': return -12;
            case 'c': return 47;
            case 'd': return 7;
            case 'e': return -32;
        }
        return 0;
    }
}

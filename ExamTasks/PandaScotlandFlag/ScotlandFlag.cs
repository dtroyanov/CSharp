using System;
using System.Text;
class ScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char tilda = '~';
        char sharp = '#';
        char letter = 'A';
        char dash = '-';

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(tilda, i));
            Console.Write(letter);
            letter++;
            if (letter > 'Z')
            {
                letter = 'A';
            }
            Console.Write(new string(sharp, n - 2 - 2 * i));
            Console.Write(letter);
            letter++;
            if (letter > 'Z')
            {
                letter = 'A';
            }
            Console.Write(new string(tilda, i));
            Console.WriteLine();
        }
        Console.WriteLine(new string(dash, n /2) + letter + new string(dash, n / 2));
        letter++;
        if (letter > 'Z')
        {
            letter = 'A';
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(tilda, n / 2 - 1 - i));
            Console.Write(letter);
            letter++;
            if (letter > 'Z')
            {
                letter = 'A';
            }
            Console.Write(new string(sharp, 2 * i + 1));
            Console.Write(letter);
            letter++;
            if (letter > 'Z')
            {
                letter = 'A';
            }
            Console.Write(new string(tilda, n / 2 - 1 - i));
            Console.WriteLine();
        }
    }
}
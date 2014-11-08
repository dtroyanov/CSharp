using System;
class Illuminati
{
    static void Main()
    {
        string message = Console.ReadLine();

        int count = 0;
        int sum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == 'a' || message[i] == 'A')
            {
                sum += 65;
                count++;
            }
            else if (message[i] == 'e' || message[i] == 'E')
            {
                sum += 69;
                count++;
            }
            else if (message[i] == 'i' || message[i] == 'I')
            {
                sum += 73;
                count++;
            }
            else if (message[i] == 'o' || message[i] == 'O')
            {
                sum += 79;
                count++;
            }
            else if (message[i] == 'u' || message[i] == 'U')
            {
                sum += 85;
                count++;
            }
        }
        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
}
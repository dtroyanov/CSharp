using System;
class BonusScore
{
    static void Main()
    {
        Console.Write("Score = ");
        int score = int.Parse(Console.ReadLine());

        if (score > 0 && score < 4)
        {
            Console.WriteLine("Bonus score is {0}", score * 10);
        }
        else if (score > 3 && score < 7)
        {
            Console.WriteLine("Bonus score is {0}", score * 100);
        }
        else if (score > 6 && score < 10)
        {
            Console.WriteLine("Bonus score is {0}", score * 1000);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}

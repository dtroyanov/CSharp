using System;
class PrintDeckOfCards
{
    static void Main()
    {
        for (int card = 1; card < 13; card++)
        {
            for (int color = 1; color <= 4; color++)
            {
                switch (card)
                {
                    case 1:
                        Console.Write("2");
                        break;
                    case 2:
                        Console.Write("3");
                        break;
                    case 3:
                        Console.Write("4");
                        break;
                    case 4:
                        Console.Write("5"); 
                        break;
                    case 5:
                        Console.Write("6"); 
                        break;
                    case 6:
                        Console.Write("7"); 
                        break;
                    case 7:
                        Console.Write("8"); 
                        break;
                    case 8:
                        Console.Write("9");
                        break;
                    case 9:
                        Console.Write("10");
                        break;
                    case 10:
                        Console.Write("J");
                        break;
                    case 11:
                        Console.Write("Q");
                        break;
                    case 12:
                        Console.Write("K");
                        break;
                    default:
                        break;
                }
                switch (color)
                {
                    case 1:
                        Console.Write((char)5 + " ");
                        break;
                    case 2:
                        Console.Write((char)4 + " ");
                        break;
                    case 3:
                        Console.Write((char)3 + " ");
                        break;
                    case 4:
                        Console.WriteLine((char)6);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

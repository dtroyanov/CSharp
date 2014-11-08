using System;
class FruitMarket
{
    static void Main()
    {
        string day = Console.ReadLine();
        decimal q1 = decimal.Parse(Console.ReadLine());
        string p1 = Console.ReadLine();
        decimal q2 = decimal.Parse(Console.ReadLine());
        string p2 = Console.ReadLine();
        decimal q3 = decimal.Parse(Console.ReadLine());
        string p3 = Console.ReadLine();

        decimal price = q1 * Price(p1, day) + q2 * Price(p2, day) + q3 * Price(p3, day);
        Console.WriteLine("{0:F2}", price);
    }
    static decimal Price(string product, string day)
    {
        decimal price = 0;
        bool isFruit = false;
        switch (product)
        {
            case "banana": isFruit = true; price = 1.80m; break;
            case "cucumber": price = 2.75m; break;
            case "tomato": price = 3.20m; break;
            case "orange": price = 1.60m; isFruit = true; break;
            case "apple": isFruit = true; price = 0.86m; break;
            default:
                break;
        }
        switch (day)
        {
            case "Friday": price *= 0.90m; break;
            case "Tuesday": if (isFruit)
                {
                    price *= 0.80m;
                }
                break;
            case "Sunday": price *= 0.95m; break;
            case "Wednesday": if (!isFruit)
                {
                    price *= 0.90m;
                }
                break;
            case "Thursday": if (product == "banana")
                {
                    price *= 0.70m;
                }
                break;
            default:
                break;
        }
        return price;
    }
}

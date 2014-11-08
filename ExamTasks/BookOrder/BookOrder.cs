using System;
class BookOrder
{
    static void Main()
    {
        int orders = int.Parse(Console.ReadLine());
        int allBooks = 0;
        double totalPrice = 0;
        for (int i = 0; i < orders; i++)
        {
            int packets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            int books = packets * booksPerPacket;
            allBooks += books;

            double discount = 0;
            if (packets >= 10 && packets < 110)
            {
                discount = packets / 10 + 4;
            }
            else if (packets >= 110)
            {
                discount = 15;
            }
            double discountPrice = books * price * (100 - discount) / 100;
            totalPrice += discountPrice;
        }
        Console.WriteLine(allBooks);
        Console.WriteLine("{0:F2}", totalPrice);
    }
}

using System;
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        number = number / 100;
        number = number % 10;

        if (number == 7)
        {
            Console.WriteLine("The third digit is 7");
        }
        else
        {
            Console.WriteLine("The third digit is not 7");
        }
    }
}
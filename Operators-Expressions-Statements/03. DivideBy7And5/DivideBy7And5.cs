using System;
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("{0} can be divided by 7 and 5.", number);
        }
        else
        {
            Console.WriteLine("{0} cannot be divided by 7 and 5.", number);
        }
    }
}
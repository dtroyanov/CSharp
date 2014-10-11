using System;
class FourDigit
{
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());

        int fourthDigit = number % 10;
        int thirdDigit = (number / 10) % 10;
        int secondDigit = (number / 100) % 10;
        int firstDigit = (number / 1000) % 10;

        Console.WriteLine("The sum of the digits is {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("Reversed number is {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("With last digit in front, the number will be {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("With exchanged second and third dight, the number will be {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}
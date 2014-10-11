using System;
class BankAccount
{
    static void Main()
    {
        string firstName = "Petar";
        string middleName = "Ivanov";
        string lastName = "Petrov";
        decimal amount = 24.34M;
        string bankName = "DSK";
        string iban = "BG05 BGSA 1914 1914 1914 24";
        long firstCreditCard = 6541464646461234;
        long secondCreditCard = 7218464646461234;
        long thirdCreditCard = 3579464646461234;
        Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("The amount of money is: ${0}M", amount);
        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit cards: \n{0}\n{1}\n{2}", firstCreditCard, secondCreditCard,thirdCreditCard);
    }
}
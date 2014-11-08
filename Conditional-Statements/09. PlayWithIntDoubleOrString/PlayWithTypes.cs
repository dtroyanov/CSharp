using System;
class PlayWithTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int a = int.Parse(Console.ReadLine());

        if (a == 1)
        {
            Console.Write("Please enter a integer: ");
            int integer = int.Parse(Console.ReadLine());
            Console.WriteLine(integer + 1);
        }
        else if (a == 2)
        {
            Console.Write("Please enter a double: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(num + 1);
        }
        else if (a == 3)
        {
            Console.Write("Please enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str + "*");
        }
    }
}

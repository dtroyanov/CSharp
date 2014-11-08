using System;
class NumbersAsWords
{
    static string UppercaseFirst(string s)
    {
        char[] a = s.ToCharArray();
        a[0] = char.ToUpper(a[0]);
        return new string(a);
    }
    static void Main()
    {
        Console.Write("Enter a number between 0 and 999: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0 || num > 999)
        {
            Console.WriteLine("Invalid number!");
        }
        else 
        { 
            int hundred = num / 100;
            int tenth = (num / 10) % 10;
            int unit = num % 10;
            string str = null;

            string[] units = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tenths = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else if ((num > 0) && (num <= 19))
            {
                str = UppercaseFirst(units[num]);
                Console.WriteLine(str);
            }
            else if ((num >= 20) && (num <= 99))
            {
                str = UppercaseFirst(tenths[tenth]) + " " + units[unit];
                Console.WriteLine(str);
            }
            else if ((num >= 100) && (tenth == 0) && (unit == 0))
            {
                str = UppercaseFirst(units[hundred]) + " hundred";
                Console.WriteLine(str);
            }
            else if ((num >= 100) && (tenth == 0) && (unit != 0))
            {
                str = UppercaseFirst(units[hundred]) + " hundred and " + units[unit];
                Console.WriteLine(str);
            }
            else if ((num >= 100) && ((num % 100) > 19))
            {
                str = UppercaseFirst(units[hundred]) + " hundred and " + tenths[tenth] + " " + units[unit];
                Console.WriteLine(str);
            }
            else if ((num >= 100) && (((num % 100) > 0) && ((num % 100) <= 19)))
            {
                str = UppercaseFirst(units[hundred]) + " hundred and " + units[(num % 100)];
                Console.WriteLine(str);
            }
        }
    }
}

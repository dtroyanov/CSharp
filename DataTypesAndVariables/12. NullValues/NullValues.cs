using System;
class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Null int: " + nullInt);
        Console.WriteLine("Null double: " + nullDouble);

        nullInt += 5;
        nullDouble += 10.2552;
        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);
    }
}

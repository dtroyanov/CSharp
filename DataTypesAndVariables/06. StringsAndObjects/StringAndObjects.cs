using System;
class StringAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "world";
        object c = a + " " + b;
        string d = (string) c;
        Console.WriteLine(d);
    }
}
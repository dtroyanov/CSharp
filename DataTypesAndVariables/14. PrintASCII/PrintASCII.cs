using System;
using System.Text;
class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {

            System.Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}
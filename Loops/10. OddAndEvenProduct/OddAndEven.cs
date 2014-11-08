using System;
class OddAndEven
{
    static void Main()
    {
        Console.Write("Enter few numbers separated by a space: ");
        string n = Console.ReadLine();
        string[] arrayN = n.Split(' ');
        int odd = 1;
        int even = 1;

        for (int i = 0; i < arrayN.Length; i++)
        {
            int num = int.Parse(arrayN[i]);
            if (i % 2 == 0)
            {
                odd *= num;
            }
            else
            {
                even *= num; 
            }
        }
        if (even == odd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", even);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", odd);
            Console.WriteLine("even_product = {0}", even);
        }

    }
}
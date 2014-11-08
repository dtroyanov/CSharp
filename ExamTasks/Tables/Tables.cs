using System;
class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long t = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        long legs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        long tables = Math.Min((legs / 4), t);

        if (tables > n)
        {
            long topsLeft = t - n;
            long legsLeft = legs - n * 4;
            Console.WriteLine("more: {0}", topsLeft);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }
        else if (tables < n)
        {
            long topsNeeded = n >= t ? n - t : 0;
            long legsNeeded = n * 4 >= legs ? n * 4 - legs : 0;
            Console.WriteLine("less: {0}", tables - n);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tables);
        }
    }
}

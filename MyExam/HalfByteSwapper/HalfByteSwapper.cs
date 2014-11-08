using System;
class HalfByteSwapper
{
    static void Main()
    {
        uint first = uint.Parse(Console.ReadLine());
        uint second = uint.Parse(Console.ReadLine());
        uint third = uint.Parse(Console.ReadLine());
        uint fourth = uint.Parse(Console.ReadLine());
        string command = "";
        string secondLine = "";
        int num1 = 0;
        int num2 = 0;
        int group1 = 0;
        int group2 = 0;
        while (command != "End")
        {
            command = Console.ReadLine();
            if (command == "End")
            {
                break;
            }
            secondLine = Console.ReadLine();
            string[] firstCommand = command.Split();
            string[] secondCommand = secondLine.Split();
            num1 = int.Parse(firstCommand[0]);
            group1 = int.Parse(firstCommand[1]);
            num2 = int.Parse(secondCommand[0]);
            group2 = int.Parse(secondCommand[1]);
            if (num1 == 0 && num2 == 0)
            {
                uint mask = 15;
                uint check = (first >> group1 * 4) & mask;
                uint secondCheck = (first >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                first = first & ~firstMask | (secondCheck << (group1 * 4));
                first = first & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 0 && num2 == 1)
            {
                uint mask = 15;
                uint check = (first >> group1 * 4) & mask;
                uint secondCheck = (second >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                first = first & ~firstMask | (secondCheck << (group1 * 4));
                second = second & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 0 && num2 == 2)
            {
                uint mask = 15;
                uint check = (first >> group1 * 4) & mask;
                uint secondCheck = (third >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                first = first & ~firstMask | (secondCheck << (group1 * 4));
                third = third & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 0 && num2 == 3)
            {
                uint mask = 15;
                uint check = (first >> group1 * 4) & mask;
                uint secondCheck = (fourth >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                first = first & ~firstMask | (secondCheck << (group1 * 4));
                fourth = fourth & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 1 && num2 == 0)
            {
                uint mask = 15;
                uint check = (second >> group1 * 4) & mask;
                uint secondCheck = (first >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                second = second & ~firstMask | (secondCheck << (group1 * 4));
                first = first & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 1 && num2 == 1)
            {
                uint mask = 15;
                uint check = (second >> group1 * 4) & mask;
                uint secondCheck = (second >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                second = second & ~firstMask | (secondCheck << (group1 * 4));
                second = second & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 1 && num2 == 2)
            {
                uint mask = 15;
                uint check = (second >> group1 * 4) & mask;
                uint secondCheck = (third >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                second = second & ~firstMask | (secondCheck << (group1 * 4));
                third = third & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 1 && num2 == 3)
            {
                uint mask = 15;
                uint check = (second >> group1 * 4) & mask;
                uint secondCheck = (fourth >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                second = second & ~firstMask | (secondCheck << (group1 * 4));
                fourth = fourth & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 2 && num2 == 0)
            {
                uint mask = 15;
                uint check = (third >> group1 * 4) & mask;
                uint secondCheck = (first >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                third = third & ~firstMask | (secondCheck << (group1 * 4));
                first = first & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 2 && num2 == 1)
            {
                uint mask = 15;
                uint check = (third >> group1 * 4) & mask;
                uint secondCheck = (second >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                third = third & ~firstMask | (secondCheck << (group1 * 4));
                second = second & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 2 && num2 == 2)
            {
                uint mask = 15;
                uint check = (third >> group1 * 4) & mask;
                uint secondCheck = (third >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                third = third & ~firstMask | (secondCheck << (group1 * 4));
                third = third & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 2 && num2 == 3)
            {
                uint mask = 15;
                uint check = (third >> group1 * 4) & mask;
                uint secondCheck = (fourth >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                third = third & ~firstMask | (secondCheck << (group1 * 4));
                fourth = fourth & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 3 && num2 == 0)
            {
                uint mask = 15;
                uint check = (fourth >> group1 * 4) & mask;
                uint secondCheck = (first >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                fourth = fourth & ~firstMask | (secondCheck << (group1 * 4));
                first = first & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 3 && num2 == 1)
            {
                uint mask = 15;
                uint check = (fourth >> group1 * 4) & mask;
                uint secondCheck = (second >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                fourth = fourth & ~firstMask | (secondCheck << (group1 * 4));
                second = second & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 3 && num2 == 2)
            {
                uint mask = 15;
                uint check = (fourth >> group1 * 4) & mask;
                uint secondCheck = (third >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                fourth = fourth & ~firstMask | (secondCheck << (group1 * 4));
                third = third & ~secondMask | (check << (group2 * 4));
            }
            else if (num1 == 3 && num2 == 3)
            {
                uint mask = 15;
                uint check = (fourth >> group1 * 4) & mask;
                uint secondCheck = (fourth >> group2 * 4) & mask;
                uint firstMask = (uint)(15 << group1 * 4);
                uint secondMask = (uint)(15 << group2 * 4);
                fourth = fourth & ~firstMask | (secondCheck << (group1 * 4));
                fourth = fourth & ~secondMask | (check << (group2 * 4));
            }
        }
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine(fourth);
    }
}

//Write an expression that extracts from given integer n the value of given bit at index p

using System;

    class ExtractBitFromInt
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int i = 1;

            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? true : false);
        }
    }

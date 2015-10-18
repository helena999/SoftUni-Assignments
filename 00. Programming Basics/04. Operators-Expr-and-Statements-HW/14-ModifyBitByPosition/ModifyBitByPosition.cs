//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. Examples:

using System;

class ModifyBitByPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            n = n & ~(1 << p); // (0 & 1 = 0); (1 & 0 = 0);
            Console.WriteLine(n);
        }
        else
        {
            n = n | (1 << p); // (0 | 1 = 1) and (0 | 1 = 1)
            Console.WriteLine(n);
        }
    }
}


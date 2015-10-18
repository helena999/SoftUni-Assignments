//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 
using System;

class ExtractThirdBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mask = 8; //00001000

        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}


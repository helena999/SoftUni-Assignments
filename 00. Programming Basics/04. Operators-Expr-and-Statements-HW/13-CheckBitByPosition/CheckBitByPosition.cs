//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

using System;

class CheckBitByPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        bool isOne = (n & (1 << p)) > 0; // (1 << p) = mask

        Console.WriteLine(isOne);

    }
}

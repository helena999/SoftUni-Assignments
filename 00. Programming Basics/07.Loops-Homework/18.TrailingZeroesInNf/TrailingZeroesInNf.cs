//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class TrailingZeroesInNf
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger countZero = 0;

        while (n/5 >= 1)
        {
            n = n/5;
            countZero += n;
        }
        Console.WriteLine(countZero);

    }
}

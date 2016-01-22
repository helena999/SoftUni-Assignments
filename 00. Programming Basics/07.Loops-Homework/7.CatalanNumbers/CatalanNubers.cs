//Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
using System;
using System.Numerics;

class CatalanNubers
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = CalculateNFactorial(2*n)/(CalculateNFactorial(n + 1)*CalculateNFactorial(n));
        Console.WriteLine(result);

    }

    static BigInteger CalculateNFactorial(BigInteger n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result*i;
        }
        return result;
    }
}

//You are given n numbers. Find an element that is equal to the sum of all of the other elements.

using System;
using System.Linq;

class SumOfElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numsArr = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        long[] numbers = Array.ConvertAll(numsArr, long.Parse);
        long maxN = numbers.Max();
        long sum = numbers.Sum();

        if (maxN == sum-maxN)
        {
            Console.WriteLine("Yes, sum={0}",maxN);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(maxN - (sum-maxN)));
        }
    }
}
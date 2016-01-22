//You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, the third and the fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. Your task is to write a program to check whether all pairs have the same value or print the max difference between two consecutive values.

using System;

class Pairs
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[input.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int first = numbers[0];
        int sec = numbers[1];
        int sum = first + sec;
        int maxDiff = 0;

        for (int i = 2; i < numbers.Length - 1; i+=2)
        {
            first = numbers[i];
            sec = numbers[i + 1];
            int nextSum = first + sec;
            int diff = Math.Abs(nextSum - sum);
            maxDiff = Math.Max(diff, maxDiff);
            sum = first + sec;
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order

using System;
using System.Collections.Generic;

class RandomizeTheNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        Random r = new Random();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        for (int i = 1; i <= n; i++)
        {
            int index = r.Next(0, numbers.Count);
            Console.Write("{0} ", numbers[index]);
            numbers.RemoveAt(index);
        }
        Console.WriteLine();
    }
}

﻿//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

using System;
using System.Linq;

class MinMaxSumAvg
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            inputArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", inputArr.Min(), inputArr.Max(), inputArr.Sum(), inputArr.Average());
    }
}

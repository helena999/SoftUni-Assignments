﻿//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. 

using System;

class NumbersNto1
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }
    }
}

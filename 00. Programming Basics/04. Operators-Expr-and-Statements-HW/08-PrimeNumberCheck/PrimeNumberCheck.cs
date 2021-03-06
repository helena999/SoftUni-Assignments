﻿//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Write a number between 1 and 100 to check is it prime." +
                          "");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        for (int devider = 2; devider <= Math.Sqrt(n); devider++)
        {
            if (n % devider == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine("Number {0} is prime? {1}", n, isPrime);
    }
}


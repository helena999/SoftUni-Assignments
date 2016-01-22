//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 

using System;

class NumbersFrom1toN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            for (int i = 1; i <=n ; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Enter a positive number");
        }
    }
}
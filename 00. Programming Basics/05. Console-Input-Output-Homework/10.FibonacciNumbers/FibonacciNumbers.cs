//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 …

using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int first = 0;
        int sec = 1;

        int third = 0;

        if (input == 1)
        {
            Console.Write("{0} ", first);
        }
        else if (input == 2)
        {
            Console.Write("{0} ", first);
            Console.Write("{0} ", sec);
        }
        else
        {
            Console.Write("{0} ", first);
            Console.Write("{0} ", sec);
            for (int i = 1; i <= input-2; i++)
            {
                third = first + sec;
                first = sec;
                sec = third;
                Console.Write("{0} ", third);
            } 
        }
        Console.WriteLine();
    }
}
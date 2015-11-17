//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class DividableNumbers
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;

        Console.WriteLine("The numbers are:");
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;

                if (i != end)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.Write("{0}", i); 
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Count of the numebrs: {0}", p);

    }
}
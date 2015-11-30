//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double c = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a>b && a>c)
        {
            Console.WriteLine(a);
        }
        else if (b>a && b>c)
        {
            Console.WriteLine(b);
        }
        else if (c>a && c>b)
        {
            
        }
        {
            Console.WriteLine(c);
        }


    }
}
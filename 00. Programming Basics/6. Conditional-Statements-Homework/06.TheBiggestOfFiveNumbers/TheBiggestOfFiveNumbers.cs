//Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double c = Double.Parse(Console.ReadLine());
        double d = Double.Parse(Console.ReadLine());
        double e = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        if ((a > b && a > c && a > d && a > e))
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c && b > d & b > e)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(d);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine(e);
        }
    }
}
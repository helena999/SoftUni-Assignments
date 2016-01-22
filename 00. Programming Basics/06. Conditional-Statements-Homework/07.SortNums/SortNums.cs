//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

using System;

class SortNums
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double first = 0;
        double sec = 0;
        double third = 0;

        if (a >= b && a >= c)
        {
            first = a;
            if (b >= c)
            {
                sec = b;
                third = c;
            }
            else
            {
                sec = c;
                third = b;
            }
        }
        else if (b >= a && b >= c)
        {
            first = b;
            if (a >= c)
            {
                sec = a;
                third = c;
            }
            else
            {
                sec = c;
                third = a;
            }
        }
        else if (c >= a && c >= b)
        {
            first = c;
            if (a >= b)
            {
                sec = a;
                third = b;
            }
            else
            {
                sec = b;
                third = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", first, sec, third);
    }
}

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class AreaTrapezoid
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine((a + b) * h * 0.5);
    }
}


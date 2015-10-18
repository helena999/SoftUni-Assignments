//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

using System;

class PointInACycle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCycle = (x * x) + (y * y) <= 2 * 2;
        Console.WriteLine(isInCycle);
    }
}


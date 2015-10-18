//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

using System;

class PointInCycleAndOutsideRectangle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCycle = (Math.Pow(x - 1, 2) + (Math.Pow(y - 1, 2)) <= 1.5 * 1.5); //chek if the dot(x,y) is in Cycle

        bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= -1);         //chek if the dot(x,y) is in Rectangle

        if (isInCycle && !isInRectangle) //isInRectangle - true; !isInRectangle = reverse true = false
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
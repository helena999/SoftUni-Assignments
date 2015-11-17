//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prdoubles its real roots). 

using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = ((b*b) - (4*a*c));
        double x1 = 0d;
        double x2 = 0d;

        if (discriminant > 0)
        {
            x1 = ((-b) - Math.Sqrt(discriminant))/(2.0*a);
            x2 = ((-b) + Math.Sqrt(discriminant)) / (2.0 * a);

            Console.WriteLine("x1 = {0}\nx2 = {1}",x1, x2);
        }
        else if (discriminant == 0)
        {
            x1 = x2 = -b/(2.0*a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No roots!");
        }
    }
}

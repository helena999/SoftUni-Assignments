//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 

using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Find circle perimeter and area! \nWrite the radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2.0*Math.PI*r;
        double area = Math.Pow(r,2)*Math.PI;
        Console.WriteLine("Result:\nPerimeter: {0:0.00}\nArea: {1:0.00}",perimeter, area);
    }
}

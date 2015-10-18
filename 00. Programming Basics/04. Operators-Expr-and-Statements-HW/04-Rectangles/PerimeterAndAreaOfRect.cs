//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class PerimeterAndAreaOfRect
{
    static void Main()
    {
        Console.WriteLine("Check the perimeter and the area of rectangle\n");
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter height:\n");
        double height = double.Parse(Console.ReadLine());

        double perimeter = ((2 * width) + (2 * height));
        Console.WriteLine("The perimeter of rectangle is: {0}\n", perimeter);

        double area = (width * height);
        Console.WriteLine("The area of rectangle is: {0}\n", area);

    }
}


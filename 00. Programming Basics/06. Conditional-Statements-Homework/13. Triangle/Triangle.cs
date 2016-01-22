//You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: A(Ax, Ay), B(Bx,  By), C(Cx, Cy). Write a program to check if these three points can form a triangle. Then calculate the area of this triangle. To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:
//D= √(〖〖(x〗_2-x_1)〗^2+〖〖(y〗_2-y_1)〗^2 )  
//You can use the inequalities of a triangle to check whether three segments a, b and c can form a triangle:
//a+b>c;  b+c>a; a+c>b
//To calculate the area you can use Heron`s formula (a method for calculating the area of a triangle when you know the lengths of all three sides). Let a, b, c be the lengths of the sides of a triangle. Thus:
//Area=√(p(p-a)(p-b)(p-c) ), where p is half the perimeter: (a+b+c)/2.


using System;

class Triangle
{
    static void Main(string[] args)
    {
        int Ax = int.Parse(Console.ReadLine());
        int Ay = int.Parse(Console.ReadLine());
        int Bx = int.Parse(Console.ReadLine());
        int By = int.Parse(Console.ReadLine());
        int Cx = int.Parse(Console.ReadLine());
        int Cy = int.Parse(Console.ReadLine());

        double a = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
        double b = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
        double c = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));

        if ((a+b>c) && (b+c>a) && (a+c>b))
        {           
            double p = (a + b + c)/2.0;
            double area = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}",area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", c);
        }
    }
}
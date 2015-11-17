//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. 

using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers, integer a, floating-point b and floating-point c");

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        if (!(0 <= a && a <= 500))
        {
            Console.WriteLine("Invalid number (0 <= a <= 500)");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
        }
        string aToBinary = Convert.ToString(a, 2);

        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", a, aToBinary.PadLeft(10,'0'), b, c);
    }
}

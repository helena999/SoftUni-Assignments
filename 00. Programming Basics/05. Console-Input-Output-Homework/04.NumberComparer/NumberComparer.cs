//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double greater = a > b ? a : b;

        Console.WriteLine(greater);
    }
}
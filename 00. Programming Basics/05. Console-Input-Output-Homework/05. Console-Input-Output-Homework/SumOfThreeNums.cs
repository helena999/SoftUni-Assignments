//Write a program that reads 3 real numbers from the console and prints their sum. 

using System;

class SumOfThreeNums
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write three numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("The sum of the numbers are: {0}", sum);

    }
}

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 

using System;

class SumOfNnumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0d;

        while (n > 0)
        {
            sum += double.Parse(Console.ReadLine());
            n--;
        }

        Console.WriteLine();
        Console.WriteLine("Sum = {0}", sum);
    }
}

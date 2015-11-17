//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] inputArr = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        double[] numbers = new double[inputArr.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(inputArr[i]);
        }

        Console.WriteLine("Sum = {0}", numbers.Sum());
    }
}

//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputArr = new string[input.Length];
        long[] binaryNum = new long[input.Length];
        long count = binaryNum.Length-1;

        double result = 0;


        for (int i = 0; i < binaryNum.Length; i++)
        {
            inputArr[i] = Convert.ToString(input[i]);
            binaryNum[i] = long.Parse(inputArr[i]);
        }

        for (int i = 0; i < binaryNum.Length; i++)
        {
            result += binaryNum[i]*Math.Pow(2, count);
            count--;
        }

        Console.WriteLine(result);
    }
}
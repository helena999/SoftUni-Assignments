//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        long input = int.Parse(Console.ReadLine());

        List<string> output = new List<string>();

        while (input != 0)
        {
            long result = input%2;
            output.Add(result.ToString());
            input = input / 2;
        }
        output.Reverse();

        foreach (var num in output)
        {
            Console.Write(num);
        }
        Console.WriteLine();

    }
}

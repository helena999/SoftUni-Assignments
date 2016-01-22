//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;
using System.Collections.Generic;

class HexToDec
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        long count = input.Length - 1;
        double result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case '0':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '1':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '2':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '3':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '4':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '5':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '6':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '7':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '8':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case '9':
                    result += double.Parse(Convert.ToString(input[i])) * Math.Pow(16, count);
                    count--;
                    break;
                case 'A':
                    result += 10.0 * Math.Pow(16, count);
                    count--;
                    break;
                case 'B':
                    result += 11.0 * Math.Pow(16, count);
                    count--;
                    break;
                case 'C':
                    result += 12.0 * Math.Pow(16, count);
                    count--;
                    break;
                case 'D':
                    result += 13.0 * Math.Pow(16, count);
                    count--;
                    break;
                case 'E':
                    result += 14.0 * Math.Pow(16, count);
                    count--;
                    break;
                case 'F':
                    result += 15.0 * Math.Pow(16, count);
                    count--;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(result);
    }
}
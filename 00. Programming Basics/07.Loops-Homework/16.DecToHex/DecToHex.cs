//Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 

using System;
using System.Collections.Generic;

class DecToHex
{
    static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());
        List<long> outputNum = new List<long>();
        List<string> decResult = new List<string>();

        while (input > 16)
        {
            long result = input % 16;
            outputNum.Add(result);
            input = input/16;
        }
        outputNum.Add(input);

        foreach (var item in outputNum)
        {
            switch (item)
            {
                case 0:
                    decResult.Add("0");
                    break;
                case 1:
                    decResult.Add("1");
                    break;
                case 2:
                    decResult.Add("2");
                    break;
                case 3:
                    decResult.Add("3");
                    break;
                case 4:
                    decResult.Add("4");
                    break;
                case 5:
                    decResult.Add("5");
                    break;
                case 6:
                    decResult.Add("6");
                    break;
                case 7:
                    decResult.Add("7");
                    break;
                case 8:
                    decResult.Add("8");
                    break;
                case 9:
                    decResult.Add("9");
                    break;
                case 10:
                    decResult.Add("A");
                    break;
                case 11:
                    decResult.Add("B");
                    break;
                case 12:
                    decResult.Add("C");
                    break;
                case 13:
                    decResult.Add("D");
                    break;
                case 14:
                    decResult.Add("E");
                    break;
                case 15:
                    decResult.Add("F");
                    break;
            }           
        }

        decResult.Reverse();
        foreach (var item in decResult)
        {
            Console.Write("{0}", item);
        }
        Console.WriteLine();
    }
}

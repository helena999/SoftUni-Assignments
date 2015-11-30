//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

using System;
using System.Security.AccessControl;

class NumberAsWord
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 999)
        {
            int temp = number;
            switch (temp/100)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("One hudnred");
                    break;
                case 2:
                    Console.Write("Two hundred");
                    break;
                case 3:
                    Console.Write("Three hundred");
                    break;
                case 4:
                    Console.Write("Four hundred");
                    break;
                case 5:
                    Console.Write("Five hundred");
                    break;
                case 6:
                    Console.Write("Six hundred");
                    break;
                case 7:
                    Console.Write("Seven hundred");
                    break;
                case 8:
                    Console.Write("Eight hundred");
                    break;
                case 9:
                    Console.Write("Nine nundred");
                    break;
                default:
                    Console.WriteLine("Error report!");
                    break;
            }
            if (temp / 100 != 0 && temp % 100 != 0)
            {
                Console.Write(" and ");
            }

            switch (temp / 10 % 10)
            {
                case 0:
                    break;
                case 1:
                    switch (temp % 10)
                    {
                        case 0:
                            Console.WriteLine("Ten");
                            break;
                        case 1:
                            Console.WriteLine("Eleven");
                            break;
                        case 2:
                            Console.WriteLine("Twelve");
                            break;
                        case 3:
                            Console.WriteLine("Thirdteen");
                            break;
                        case 4:
                            Console.WriteLine("Fourteen");
                            break;
                        case 5:
                            Console.WriteLine("Fifteen");
                            break;
                        case 6:
                            Console.WriteLine("Sixteen");
                            break;
                        case 7:
                            Console.WriteLine("Seventeen");
                            break;
                        case 8:
                            Console.WriteLine("Eighteen");
                            break;
                        case 9:
                            Console.WriteLine("Nineteen");
                            break;
                        default:
                            Console.WriteLine("Error report!");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Fourty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
                default:
                    Console.Write("Error report!");
                    break;
            }
        switch (temp % 10)
            {
                case 0:
                    if (temp == 0)
                    {
                        Console.Write("zero");
                    }
                    Console.Write("\n");
                    break;
                case 1:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("one");
                    break;
                case 2:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("two");
                    break;
                case 3:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("three");
                    break;
                case 4:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("four");
                    break;
                case 5:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("five");
                    break;
                case 6:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("six");
                    break;
                case 7:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("seven");
                    break;
                case 8:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("eight");
                    break;
                case 9:
                    if (temp / 10 % 10 == 1) break;
                    Console.WriteLine("nine");
                    break;
                default: 
                    Console.WriteLine("Error report!"); 
                    break;
            }
        }
        else
        {
            Console.WriteLine("Out of range!");
        }




    }
}

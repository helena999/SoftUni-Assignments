//Write an expression that checks for given integer if its third digit from right-to-left is 7. 

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if third digit is 7\n");
        int number = int.Parse(Console.ReadLine());

        int numberTwo = number / 100;
        int numberThree = numberTwo % 10;

        bool isSeven = numberThree == 7;
        Console.WriteLine("\n7 is the third digit of the number {0} -> {1}", number, isSeven);

    }
}
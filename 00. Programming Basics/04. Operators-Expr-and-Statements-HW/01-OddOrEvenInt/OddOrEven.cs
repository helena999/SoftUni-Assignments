//Write an expression that checks if given integer is odd or even. Examples:

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());

        bool oddOrEaven = number % 2 == 0;
        Console.WriteLine("Is number" + " " + number + " " + "even? -> {0}", oddOrEaven);
    }
}


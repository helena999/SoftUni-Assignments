//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 

using System;

class DivideBy
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it can be divided by 7 and 5 in the same time:");

        int number = int.Parse(Console.ReadLine());
        int divisorOne = 7;
        int divisorTwo = 5;
        int divisors = divisorOne * divisorTwo;

        bool quotient = (number % divisors == 0);
        Console.WriteLine("Is the number {0} divided by 7 and 5 at the same time: -> {1}", number, quotient);
    }
}

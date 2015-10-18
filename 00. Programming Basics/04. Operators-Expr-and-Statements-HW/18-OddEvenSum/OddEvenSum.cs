////This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
//You are given a number n and 2*n numbers. Write a program to check whether the sum of the odd numbers is equal to the sum of the even n numbers. The first number is considered odd, the next even, the next odd again, etc. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the odd and the even sums.


using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int oddNumber = 0;
        int evenNumber = 0;
        int sumOdd = 0;
        int sumEven = 0;

        for (int i = 0; i < n; i++)
        {
            oddNumber = int.Parse(Console.ReadLine());
            evenNumber = int.Parse(Console.ReadLine());

            sumOdd += oddNumber;
            sumEven += evenNumber;
        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
        }

    }
}
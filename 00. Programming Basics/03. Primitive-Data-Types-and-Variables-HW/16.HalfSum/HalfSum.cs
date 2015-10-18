//Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game. He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums the left and right sub-sums, and compares the sub-sums. Please help him.
//You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the left and the right sums.


using System;

    class HalfSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secSum = 0;

            for (int i = 1; i <= n*2; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i<=n)
                {
                    firstSum += input;
                }
                else
                {
                    secSum += input;
                }                            
            }

            if (firstSum == secSum)
            {
                Console.WriteLine("Yes, sum={0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(firstSum-secSum));
            }
        }
    }
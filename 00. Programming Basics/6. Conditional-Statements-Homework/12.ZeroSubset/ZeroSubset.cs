//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 
using System;

class ZeroSubset
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[inputArr.Length];
        bool subsetFound = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputArr[i]);
        }
        
        for (int startPos = 0; startPos < numbers.Length; startPos++)
        {
            int sum = 0;
            for (int endPos = startPos; endPos < numbers.Length; endPos++)
            {
                sum += numbers[endPos];
                if (sum == 0)
                {
                    subsetFound = true;
                    Console.Write("Subset found: ");
                    for (int i = startPos; i <= endPos; i++)
                    {
                        Console.Write("{0} ", numbers[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
        if (subsetFound == false)
        {
            Console.WriteLine("Subset not found!");
        }
    }
}
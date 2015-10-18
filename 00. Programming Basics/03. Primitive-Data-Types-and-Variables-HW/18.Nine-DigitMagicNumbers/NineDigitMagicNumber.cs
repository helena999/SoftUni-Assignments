//Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums of digits, as well as to split them into triples with special properties. Help her to calculate very special numbers called “nine-digit magic numbers”.
//You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format abcdefghi, such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of digits is sum and abc ≤ def ≤ ghi. Numbers holding these properties are also called “nine-digit magic numbers”.
//Your task is to write a program to print these numbers in increasing order.


using System;

    class NineDigitMagicNumber
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());

            int abc;
            int def;
            int ghi;

            int resultCount = 0;

            for (abc = 111; abc <= 777; abc++)
            {
                def = abc + diff;
                ghi = def + diff;
                bool isEqual = ((SumOfDigits(abc) + SumOfDigits(def) + SumOfDigits(ghi)) == sum);

                if (isAllowedNumber(abc) && 
                    isAllowedNumber(def) && 
                    isAllowedNumber(ghi) &&
                    ghi <= 777 &&
                    isEqual)
                    
                {
                    Console.WriteLine("{0}{1}{2}",abc, def, ghi);
                    resultCount++;
                }
            }

            if (resultCount == 0)
            {
                Console.WriteLine("No");
            }
        }
        
        //Boolean Methot to chek if the each set of three digits (from 111 to 777) contains 0, 7, 8 or 9
        private static bool isAllowedNumber(int num)
        {
            string number = num.ToString();

            foreach (var digit in number)
            {
                if (digit < '1' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }

        //Method for calculating the sum of digits of one set number
        private static int SumOfDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            return sum;
        }
    }

    


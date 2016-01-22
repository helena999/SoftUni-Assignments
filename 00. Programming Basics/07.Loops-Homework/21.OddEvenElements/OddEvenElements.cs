//You are given N numbers. Calculate the sum, min and max of its odd elements and sum, min and max of its even elements. Consider that the first element is odd, the second is even, etc.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class OddEvenElements
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string input = Console.ReadLine();
        string[] inputNum = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        List<double> oddNums = new List<double>();
        List<double> evenNums = new List<double>();

        double sumOdd = 0;
        double minOdd = 0;
        double maxOdd = 0;

        double sumEven = 0;
        double minEven = 0;
        double maxEven = 0;


        for (int i = 0; i < inputNum.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddNums.Add(double.Parse(inputNum[i]));
            }
            else
            {
                evenNums.Add(double.Parse(inputNum[i]));
            }
        }

        if (oddNums.Count > 0 && evenNums.Count > 0)
        {
            sumOdd = oddNums.Sum();
            minOdd = oddNums.Min();
            maxOdd = oddNums.Max();

            sumEven = evenNums.Sum();
            minEven = evenNums.Min();
            maxEven = evenNums.Max();

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", sumOdd, minOdd, maxOdd, sumEven, minEven, maxEven);
        }
        else if (oddNums.Count == 0 && evenNums.Count > 0)
        {
            sumEven = evenNums.Sum();
            minEven = evenNums.Min();
            maxEven = evenNums.Max();

            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={0}, EvenMin={1}, EvenMax={2}", sumEven, minEven, maxEven);
        }
        else if (oddNums.Count > 0 && evenNums.Count == 0)
        {
            sumOdd = oddNums.Sum();
            minOdd = oddNums.Min();
            maxOdd = oddNums.Max();

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", sumOdd, minOdd, maxOdd);
        }
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }

    }
}

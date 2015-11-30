//Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007. We calculate the weight of this date by joining together all its digits, multiplying each digit by each of the other digits and finally sum all obtained products. In our case we will have 8-digits: 17032007, so the weight is 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
//Your task is to write a program that finds all magic dates: dates between two fixed years matching given magic weight. The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar (years have 12 months, each having 28, 29, 30 or 31 days, etc.). Years start from 1 January and end in 31 December.


using System;

class MagicDates
{
    static void Main(string[] args)
    {
        DateTime startYear = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        DateTime endYear = new DateTime(int.Parse(Console.ReadLine()), 12, 31);
        int magicWeight = int.Parse(Console.ReadLine());
        int count = 0;

        while (startYear <= endYear)
        {
            //dd.mm.yyyy - 8 digits
            int d1 = startYear.Day / 10;
            int d2 = startYear.Day % 10;
            int d3 = startYear.Month / 10;
            int d4 = startYear.Month % 10;
            int d5 = startYear.Year / 1000;
            int d6 = (startYear.Year / 100) % 10;
            int d7 = (startYear.Year / 10) % 10;
            int d8 = (startYear.Year % 10);

            long dateWeight = ((d1 * d2 + d1 * d3 + d1 * d4 + d1 * d5 + d1 * d6 + d1 * d7 + d1 * d8) +
                                (d2 * d3 + d2 * d4 + d2 * d5 + d2 * d6 + d2 * d7 + d2 * d8) + (d3 * d4 + d3 * d5 + d3 * d6 + d3 * d7 + d3 * d8) +
                                (d4 * d5 + d4 * d6 + d4 * d7 + d4 * d8) + (d5 * d6 + d5 * d7 + d5 * d8) + (d6 * d7 + d6 * d8) + (d7 * d8));

            if (dateWeight == magicWeight)
            {
                Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", d1, d2, d3, d4, d5, d6, d7, d8);
                count++;
            }
            startYear = startYear.AddDays(1);
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
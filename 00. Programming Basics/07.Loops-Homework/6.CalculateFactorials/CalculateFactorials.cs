//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
//Examples:
//n	k	n!/k!
//5	2	60
//6	5	6
//8	3	6720

using System;

class CalculateFactorials
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        int k = Int32.Parse(Console.ReadLine());

        if ((k>1)&&(k<n)&& (n<100))
        {


            double nFactorial = 1;
            double kFactorial = 1;
            double nMinusK = n - k;
            double nMinusKF = 1;
            double last = 1;
            double quotient = 0; //result

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
                if (i <= k)
                {
                    kFactorial = kFactorial * i;
                }
                if (i <= nMinusK)
                {
                    nMinusKF = nMinusKF * i;
                }
            }


            quotient = nFactorial / (kFactorial * nMinusKF);
            Console.WriteLine("{0}", quotient);
        }
        else
        {
            Console.WriteLine("Please correct numbers (1 < k < n < 100)");
        }

            
    }
}

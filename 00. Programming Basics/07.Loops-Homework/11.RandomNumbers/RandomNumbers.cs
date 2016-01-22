//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 

using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random r = new Random();

        while (n > 0)
        {

            Console.WriteLine("{0} ", r.Next(min, max+1));
            n--;
        }
    }
}